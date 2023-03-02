using System;
using System.Net.Http;
using System.Windows.Forms;
using Capture;
using SpotifyDownloader.Properties;

namespace SpotifyDownloader
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            this.InitializeComponent();

            var spotifyAuthorize = new SpotifyAuthorize(Settings.Default.ClientId)
            {
                RedirectUri = "https://www.crexium.com/'"
            };

            var uri = spotifyAuthorize.GetAuthorizeUri();

            HttpHelper.UploadString(uri, HttpMethod.Post, null);
        }
    }
}