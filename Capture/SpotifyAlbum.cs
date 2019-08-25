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
    public sealed class SpotifyAlbum
    {
        public string Name { get; internal set; }

        public SpotifySong[] SongCollection { get; internal set; }

        public Image Artwork { get; internal set; }


        public static SpotifyAlbum DownloadAlbumInfo(string albumId)
        {
            var uri = GetAlbumUri(albumId);
            var spotifyAlbum = new SpotifyAlbum();

            HttpHelper.DownloadString(uri, (response) =>
            {
                dynamic album = JsonConvert.DeserializeObject(response);

                spotifyAlbum.Name = album["name"].ToString();

                var songCount = album["total_tracks"].ToString();
                spotifyAlbum.SongCollection = new SpotifySong[int.Parse(songCount)];

                for (var i = 0; i < spotifyAlbum.SongCollection.Length; i++)
                {
                    var songData = album["tracks"]["items"][i].href.ToString();
                    songData = Path.GetFileName(songData);

                    spotifyAlbum.SongCollection[i] = SpotifySong.DownloadSongInfo(songData);
                }
                spotifyAlbum.Artwork = spotifyAlbum.SongCollection[0].Artwork;
            });

            return spotifyAlbum;
        }


        private static Uri GetAlbumUri(string albumId)
        {
            var builder = new StringBuilder();
            builder.Append(HttpHelper.SpotifyApi);
            builder.Append("albums/");
            builder.Append(albumId);

            return new Uri(builder.ToString());
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", SongCollection[0].Artist, Name);
        }
    }
}