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
using System.Text;
using System.Windows.Forms;
using Capture;
using SpotifyDownloader.Properties;

namespace SpotifyDownloader
{
    public class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {

            SpotifyAuthorize authorize = new SpotifyAuthorize(Settings.Default.ClientId);
            var token = authorize.DownloadToken(Settings.Default.SecretId);

            HttpHelper.InitializeHeaders(new SpotifyAccount(token.AccessToken));
            var user = SpotifyUser.DownloadUserInfo("21n2wmjojfgrade27s3qoozvq");

            SpotifyPlayer player = user.GetPlayer();


            Console.ReadKey();
            //Application.Run(new SpotifyRecorder());
        }
    }
}
