// Source: Program
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

namespace Capture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var href = "https://api.spotify.com/v1/albums/3a0UOgDWw2pTajw85QPMiz/tracks?offset=0&limit=2&market=US";

            var account = SpotifyAccount.Default;
            HttpHelper.InitializeHeaders(account);

            var playlist = SpotifyPlaylist.DownloadPlaylistInfo("4hOAog9kzmwZJ7GKKqneE4");
            
            
            Console.ReadKey();
        }
    }
}