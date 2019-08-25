// Source: HttpHelper
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
using System.Drawing;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Capture
{
    public sealed class SpotifySong
    {
        public string Track { get; internal set; }

        public string Album { get; internal set; }

        public string Artist { get; internal set; }

        public TimeSpan Duration { get; internal set; }

        public Image Artwork => Bitmap.FromStream(new MemoryStream(HttpHelper.DownloadData(artworkLocation)));

        public int Number { get; internal set; }

        public DateTime ReleaseDate { get; internal set; }


        private string artworkLocation;


        public static SpotifySong DownloadSongInfo(string songId)
        {
            var builder = GetSongUri(songId);
            var spotifySong = new SpotifySong();

            HttpHelper.DownloadString(builder, (response) =>
            {
                dynamic song = JsonConvert.DeserializeObject(response);

                spotifySong.Track = song["name"].ToString();
                spotifySong.Album = song["album"].name;
                spotifySong.Artist = song["artists"][0].name;
                spotifySong.Number = int.Parse((string)song["track_number"].ToString());

                var duration = int.Parse(song["duration_ms"].ToString());
                spotifySong.Duration = TimeSpan.FromMilliseconds(duration);

                if (song["album"]["images"] != null)
                {
                    var imagePaths = song["album"]["images"];
                    if (imagePaths.Next != null)
                    {
                        var albumLocation = (string)imagePaths[0]["url"].ToString();
                        Console.WriteLine(albumLocation);
                        spotifySong.artworkLocation = albumLocation;
                    }
                }

                var dateTime = DateTime.MinValue;
                var values = song["album"]["release_date"].ToString().Split(new char[] { '-' });
                switch (values.Length)
                {
                    case 0:
                        dateTime = DateTime.MinValue;
                        break;
                    case 1:
                        dateTime = new DateTime(int.Parse(values[0]), 1, 1);
                        break;
                    case 2:
                        dateTime = new DateTime(int.Parse(values[0]), int.Parse(values[1]), 1);
                        break;
                    case 3:
                        dateTime = new DateTime(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]));
                        break;
                }
            });

            return spotifySong;
        }

        private static Uri GetSongUri(string songId)
        {
            var builder = new StringBuilder();
            builder.Append(HttpHelper.SpotifyApi);
            builder.Append("tracks/");
            builder.Append(songId);

            return new Uri(builder.ToString());
        }
    }
}