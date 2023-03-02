using System;
using System.Windows.Forms;
using Capture;
using SpotifyDownloader.Properties;

namespace SpotifyDownloader
{
    public partial class SpotifyRecorder : Form
    {
        private const string clientId = "bd072f28c9de4e77948dcb5a4c60326f";
        private const string clientSecret = "5f2dfa6780ad49259e43e6a65a28ceba";

        private bool AutoCapture { get; set; }

        private SpotifyPlayer player;
        private SpotifyAccount account;
        private string saveDirectory;


        public SpotifyRecorder()
        {
            this.InitializeComponent();

            this.saveDirectory = Environment.CurrentDirectory;
            var authorize = new SpotifyAuthorize(Settings.Default.ClientId);
            var token = authorize.DownloadToken(Settings.Default.SecretId);

            this.account = new SpotifyAccount(token.AccessToken);
            this.oAuthTokenTextbox.Text = this.account.AuthToken;
            this.player = new SpotifyPlayer();
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            this.player = SpotifyPlayer.GetPlayer();
            var cSong = this.player.CurrentSong;
            this.trackLabel.Text = cSong.Track;

            base.OnInvalidated(e);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    this.saveDirectory = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void AutoCapRadio_CheckedChanged(object sender, EventArgs e)
        {
            AutoCapture = this.autoCapRadio.Checked;
        }
    }
}