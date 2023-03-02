// Source: SongRecorder
/* 
   ---------------------------------------------------------------
                        CREXIUM ENTERTAINMENT
   ---------------------------------------------------------------

     The software is provided 'AS IS', without warranty of any kind,
   express or implied, including but not limited to the warrenties
   of merchantability, fitness for a particular purpose and
   noninfringement. In no event shall the authors or copyright
   holders be liable for any claim, damages, or other liability,
   whether in an action of contract, tort, or otherwise, arising
   from, out of or in connection with the software or the use of
   other dealings in the software.
*/

using System;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using Capture;
using NAudio.CoreAudioApi;
using NAudio.Lame;
using NAudio.Wave;

namespace SpotifyDownloader
{
    public class SongRecorder : IDisposable
    {
        public SpotifySong Song => this.song;

        public TimeSpan CurrentTime => this.elapsed;

        public string AbsolutePath => Path.Combine(this.Song.Artist, this.Song.Album, this.Song.Track);

        private SpotifySong song;
        private Timer timer;
        private WasapiCapture capture;
        private LameMP3FileWriter fileWriter;
        private TimeSpan elapsed;
        private bool isEndOfSong;
        private bool timerRunning;

        public SongRecorder(SpotifySong song)
        {
            this.song = song;
            this.timer = new Timer()
            {
                Interval = 1000,
                AutoReset = true,
            };
            this.timer.Elapsed += new ElapsedEventHandler(this.OnElapsedTimer);
            this.capture = new WasapiCapture(WasapiCapture.GetDefaultCaptureDevice());
            this.capture.DataAvailable += new EventHandler<WaveInEventArgs>(this.OnDataAvailable);
            this.fileWriter = new LameMP3FileWriter(this.AbsolutePath + ".mp3", WaveFormat.CreateIeeeFloatWaveFormat(44100, 2), LAMEPreset.ABR_320);
        }

        private void OnElapsedTimer(object sender, ElapsedEventArgs e)
        {
            this.isEndOfSong = this.elapsed >= this.Song.Duration;

            if (this.isEndOfSong)
            {
                if (this.timerRunning)
                {
                    this.Dispose();
                    return;
                }
            }

            this.elapsed += TimeSpan.FromSeconds(1.0);
        }

        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (!this.isEndOfSong)
            {
                this.fileWriter.Write(e.Buffer, 0, e.Buffer.Length);
            }
            else
            {
                this.Dispose();
            }
        }

        private async Task<TimeSpan> BeginRecording()
        {
            var task = Task.Run(async () =>
            {
                await Task.Delay(1);

                this.timerRunning = true;
                this.timer.Start();

                this.capture.StartRecording();

                return this.elapsed;
            });

            return await task;
        }

        public void Dispose()
        {
            this.fileWriter.Close();

            if (this.capture.CaptureState == CaptureState.Capturing)
                this.capture.StopRecording();

            this.isEndOfSong = false;
            this.elapsed = TimeSpan.MinValue;

            if (this.timerRunning)
                this.timer.Stop();

            this.timer = null;
            this.song = null;
            this.capture = null;
            this.fileWriter = null;
        }
    }
}