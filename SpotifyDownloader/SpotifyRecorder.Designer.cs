namespace SpotifyDownloader
{
    partial class SpotifyRecorder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.capProgress = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.oAuthTokenTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.initialTextBox = new System.Windows.Forms.TextBox();
            this.autoCapRadio = new System.Windows.Forms.RadioButton();
            this.captureButton = new System.Windows.Forms.Button();
            this.cancelCaptureButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yearReleasedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.albumArtworkPicBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtworkPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // capProgress
            // 
            this.capProgress.Location = new System.Drawing.Point(12, 92);
            this.capProgress.Name = "capProgress";
            this.capProgress.Size = new System.Drawing.Size(476, 19);
            this.capProgress.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.oAuthTokenTextbox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.capProgress);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.initialTextBox);
            this.groupBox1.Controls.Add(this.autoCapRadio);
            this.groupBox1.Controls.Add(this.captureButton);
            this.groupBox1.Controls.Add(this.cancelCaptureButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Spotify OAuth Token";
            // 
            // oAuthTokenTextbox
            // 
            this.oAuthTokenTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oAuthTokenTextbox.Location = new System.Drawing.Point(3, 146);
            this.oAuthTokenTextbox.Name = "oAuthTokenTextbox";
            this.oAuthTokenTextbox.ReadOnly = true;
            this.oAuthTokenTextbox.Size = new System.Drawing.Size(488, 20);
            this.oAuthTokenTextbox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Capture Progress";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(413, 51);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 9;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // initialTextBox
            // 
            this.initialTextBox.Location = new System.Drawing.Point(12, 53);
            this.initialTextBox.Name = "initialTextBox";
            this.initialTextBox.Size = new System.Drawing.Size(395, 20);
            this.initialTextBox.TabIndex = 8;
            // 
            // autoCapRadio
            // 
            this.autoCapRadio.AutoSize = true;
            this.autoCapRadio.Location = new System.Drawing.Point(12, 22);
            this.autoCapRadio.Name = "autoCapRadio";
            this.autoCapRadio.Size = new System.Drawing.Size(87, 17);
            this.autoCapRadio.TabIndex = 7;
            this.autoCapRadio.TabStop = true;
            this.autoCapRadio.Text = "Auto Capture";
            this.autoCapRadio.UseVisualStyleBackColor = true;
            this.autoCapRadio.CheckedChanged += new System.EventHandler(this.AutoCapRadio_CheckedChanged);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(288, 16);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(97, 23);
            this.captureButton.TabIndex = 5;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            // 
            // cancelCaptureButton
            // 
            this.cancelCaptureButton.Location = new System.Drawing.Point(391, 16);
            this.cancelCaptureButton.Name = "cancelCaptureButton";
            this.cancelCaptureButton.Size = new System.Drawing.Size(97, 23);
            this.cancelCaptureButton.TabIndex = 6;
            this.cancelCaptureButton.Text = "Cancel";
            this.cancelCaptureButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.durationLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.yearReleasedLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.albumLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.artistLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.albumArtworkPicBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Playing";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(226, 100);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(43, 13);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "<Null?>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duration:";
            // 
            // yearReleasedLabel
            // 
            this.yearReleasedLabel.AutoSize = true;
            this.yearReleasedLabel.Location = new System.Drawing.Point(226, 79);
            this.yearReleasedLabel.Name = "yearReleasedLabel";
            this.yearReleasedLabel.Size = new System.Drawing.Size(43, 13);
            this.yearReleasedLabel.TabIndex = 5;
            this.yearReleasedLabel.Text = "<Null?>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year Released:";
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(226, 58);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(43, 13);
            this.albumLabel.TabIndex = 7;
            this.albumLabel.Text = "<Null?>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Album:";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(226, 37);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(43, 13);
            this.artistLabel.TabIndex = 9;
            this.artistLabel.Text = "<Null?>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Artist:";
            // 
            // trackLabel
            // 
            this.trackLabel.AutoSize = true;
            this.trackLabel.Location = new System.Drawing.Point(226, 16);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(43, 13);
            this.trackLabel.TabIndex = 11;
            this.trackLabel.Text = "<Null?>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Track:";
            // 
            // albumArtworkPicBox
            // 
            this.albumArtworkPicBox.Location = new System.Drawing.Point(6, 15);
            this.albumArtworkPicBox.Name = "albumArtworkPicBox";
            this.albumArtworkPicBox.Size = new System.Drawing.Size(128, 128);
            this.albumArtworkPicBox.TabIndex = 2;
            this.albumArtworkPicBox.TabStop = false;
            // 
            // SpotifyRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 318);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpotifyRecorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotifyRecorder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtworkPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar capProgress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox initialTextBox;
        private System.Windows.Forms.RadioButton autoCapRadio;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button cancelCaptureButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label yearReleasedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trackLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox albumArtworkPicBox;
        private System.Windows.Forms.TextBox oAuthTokenTextbox;
        private System.Windows.Forms.Label label6;
    }
}