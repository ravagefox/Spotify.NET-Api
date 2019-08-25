// Source: SpotifyPlaylist
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
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Capture
{
    public sealed class SpotifyPlaylist
    {

        public SpotifySong[] SongCollection { get; internal set; }

        public int Count => this.SongCollection.Length;


        public static SpotifyPlaylist DownloadPlaylistInfo(string playlistId)
        {
            var playlist = new SpotifyPlaylist();
            var list = DownloadRawPlaylist(GetPlaylistUri(playlistId));

            var hasNext = list["next"] != null;
            var songs = new List<SpotifySong>();

            songs.AddRange(GetSet(list));

            while (hasNext)
            {
                Console.WriteLine(list["next"].ToString());

                var data = DownloadRawPlaylist(new Uri(list["next"].ToString()));

                songs.AddRange(GetSet(data));

                hasNext = data["next"] != null;

                if (hasNext)
                    list = data;
            }

            playlist.SongCollection = songs.ToArray();
            Console.WriteLine(playlist.SongCollection.Length);
            return playlist;
        }

        private static dynamic DownloadRawPlaylist(Uri uri)
        {
            dynamic playlistData = null;
            HttpHelper.DownloadString(uri, (response) =>
            {
                playlistData = JsonConvert.DeserializeObject(response);
            });

            return playlistData;
        }


        private static IEnumerable<SpotifySong> GetSet(dynamic setData)
        {
            var songCollection = new List<SpotifySong>();
            var items = setData["items"];
            var index = 0;

            for (index = 0; index < items.Count; index++)
            {
                var songUri = items[index]["track"].href.ToString();
                SpotifySong song = SpotifySong.DownloadSongInfo(Path.GetFileName(songUri));
                Console.WriteLine(song.Track);
                songCollection.Add(song);
            }

            return songCollection;
        }

        private static Uri GetPlaylistUri(string playlistId)
        {
            var builder = new StringBuilder();
            builder.Append(HttpHelper.SpotifyApi);
            builder.Append("playlists/");
            builder.Append(playlistId);
            builder.Append("/tracks");

            return new Uri(builder.ToString());
        }
    }
}