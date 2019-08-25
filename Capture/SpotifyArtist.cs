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
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Capture
{
    public sealed class SpotifyArtist
    {
        public SpotifyAlbum[] AlbumCollection { get; internal set; }

        public string Name { get; internal set; }


        public static SpotifyArtist DownloadArtistInfo(string artistId, bool getAllAlbums = true)
        {
            var uri = GetArtistUri(artistId);
            var spotifyArtist = new SpotifyArtist();

            HttpHelper.DownloadString(uri, (response) =>
            {
                dynamic artistInfo = JsonConvert.DeserializeObject(response);

                if (getAllAlbums)
                {
                    var albumUri = new Uri(string.Format("{0}artists/{1}/albums", HttpHelper.SpotifyApi, artistId));
                    HttpHelper.DownloadString(albumUri, (albums) =>
                    {
                        dynamic allAlbums = JsonConvert.DeserializeObject(albums);

                        int albumCount = int.Parse(allAlbums["limit"].ToString());
                        Console.WriteLine(albumCount);
                        spotifyArtist.AlbumCollection = new SpotifyAlbum[albumCount];
                        dynamic itemArray = allAlbums["items"];

                        for (var i = 0; i < albumCount; i++)
                        {
                            var albumId = Path.GetFileName(itemArray[i].href.ToString());
                            SpotifyAlbum album = SpotifyAlbum.DownloadAlbumInfo(albumId);
                            spotifyArtist.AlbumCollection[i] = album;

                            Console.WriteLine(album.Name);
                        }
                    });
                }

                spotifyArtist.Name = (string)artistInfo.name.ToString();
            });

            return spotifyArtist;
        }

        private static Uri GetArtistUri(string artistId)
        {
            var builder = new StringBuilder();
            builder.Append(HttpHelper.SpotifyApi);
            builder.Append("artists/");
            builder.Append(artistId);

            return new Uri(builder.ToString());
        }

        public override string ToString()
        {
            return Name;
        }
    }
}