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
using System.Net;
using System.Threading.Tasks;

namespace Capture
{
    public static class HttpHelper
    {
        static HttpHelper()
        {
            if (context == null)
            {
                context = new WebClient();
            }
        }

        public const string SpotifyApi = "https://api.spotify.com/v1/";
        private static readonly WebClient context;


        public static SpotifyAccount BearerToken { get; set; }

        public static event EventHandler DownloadCompleted;


        public static void InitializeHeaders(SpotifyAccount account)
        {
            BearerToken = account;

            context.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            context.Headers.Add(HttpRequestHeader.Accept, "application/json");
            context.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + BearerToken.AuthToken);
        }


        public static byte[] DownloadData(string location)
        {
            return context.DownloadData(location);
        }

        public static void DownloadString(Uri location, Action<string> callback)
        {
            var data = context.DownloadString(location.AbsoluteUri);
            if (!string.IsNullOrEmpty(data))
            {
                callback?.Invoke(data);
                DownloadCompleted?.Invoke(context, null);
            }
        }
    }
}