using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using Google.Apis.Discovery.v1;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using VideoLibrary;
using System.Threading;
using System.Net;
using FairyFileRenamerProject;

namespace FairyFileRenamerProject
{
    public partial class MainForm : Form
    {
        YouTubeVideo[] videos;
        public MainForm()
        {
            InitializeComponent();
            cboResolution.SelectedIndex = 0;
            
        }
        private void loadSongsButton_Click(object sender, EventArgs e)
        {
            string playListID = "";
            int index = downloadLinkTextBox.Text.LastIndexOf("list=") + 5;
            while(index < downloadLinkTextBox.Text.Length)
            {
                playListID += downloadLinkTextBox.Text[index++];
            }

            videos = YouTubeApi.GetPlayList(playListID);

            foreach (var video in videos)
            {
                songTitlesList.Items.Add(video.title + " " + video.id);
            }
            selectAllCheckbox.Checked = true;
            CheckAllItems();

            /*
            YouTubeVideo video = new YouTubeVideo(downloadLinkTextBox.Text);
            songTitlesList.Items.Add(video.title + " " + video.id);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                destinationTextBox.Text = fbd.SelectedPath;

            }
        }

        private void selectAllCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckAllItems();
        }
        public void CheckAllItems()
        {
            for (int i = 0; i < songTitlesList.Items.Count; i++)
            {
                if (selectAllCheckbox.Checked)
                    songTitlesList.SetItemCheckState(i, CheckState.Checked);
                else
                    songTitlesList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        void SaveAudioToDisk(string ID)
        {
            MessageBox.Show("https://www.youtube.com/watch?v=" + ID);
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls("https://www.youtube.com/watch?v=" + ID);
            
            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(cboResolution.Text));

            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            VideoDownloader downloader = new VideoDownloader(video, Path.Combine(Application.StartupPath + "\\", video.Title + video.VideoExtension));

            Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };

            thread.Start();
            
        }

        private void downloadVideosButton_Click(object sender, EventArgs e)
        {
            downloadStatusProgressbar.Maximum = videos.Length;
            downloadStatusProgressbar.Value = 1;
            downloadStatusProgressbar.Step = 1;
            foreach (var video in videos)
            {
                SaveAudioToDisk(video.id);
                downloadStatusProgressbar.PerformStep();
                MessageBox.Show("WAIT");
            }
        }
    }
}
