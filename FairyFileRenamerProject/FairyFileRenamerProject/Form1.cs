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
using System.Threading;
using System.Net;
using FairyFileRenamerProject;
using YoutubeExtractor;
using System.Text.RegularExpressions;
using System.Collections;

namespace FairyFileRenamerProject
{
    public partial class MainForm : Form
    {
        YouTubeVideo[] videos;
        List<string> mp4Files;
        BackgroundWorker dlManager;
        List<BackgroundDownloader> bkgdls;
        List<YouTubeVideo> checkedVideos;
        int nextDownload = 0;
        public MainForm()
        {
            InitializeComponent();
            cboResolution.SelectedIndex = 0;
            mp4Files = new List<string>();

            dontRenameCheckbox.Checked = Properties.Settings.Default.checkboxDoNotRename;
            dontDeleteVideoCheckbox.Checked = Properties.Settings.Default.checkboxDoNotDeleteVideo;
            dontConvertCheckbox.Checked = Properties.Settings.Default.checkboxDoNotConvert;

            destinationTextBox.Text = Properties.Settings.Default.destinationPath;
            
        }
        private void loadSongsButton_Click(object sender, EventArgs e)
        {
            BackgroundWorker titlesWorker = new BackgroundWorker();
            titlesWorker.DoWork += titlesWorker_DoWork;
            titlesWorker.RunWorkerCompleted += titlesWorker_RunWorkerCompleted;
            titlesWorker.RunWorkerAsync();

            loadSongsButton.Text = "Loading Titles, please wait...";
            loadSongsButton.Enabled = false;
            loadSongsButton.BackColor = Color.FromArgb(255, 70, 0, 0);
  
        }
        private void titlesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string playListID = "";
            int index = downloadLinkTextBox.Text.LastIndexOf("list=") + 5;
            while (index < downloadLinkTextBox.Text.Length)
            {
                playListID += downloadLinkTextBox.Text[index++];
            }

            videos = YouTubeApi.GetPlayList(playListID);

            
        }
        private void titlesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int i = 0;
            foreach (var video in videos)
            {
                songTitlesList.Items.Add(i++ + " " + video.title);
            }
            selectAllCheckbox.Checked = true;
            CheckAllItems();
            loadSongsButton.Text = "Load Link and Display Song Titles";
            loadSongsButton.Enabled = true;
            loadSongsButton.BackColor = Color.FromArgb(255, 120, 0, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                destinationTextBox.Text = fbd.SelectedPath;
                Properties.Settings.Default.destinationPath = destinationTextBox.Text;
                saveSettings();
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
    
        private void downloadVideosButton_Click(object sender, EventArgs e)
        {

            downloadStatusProgressbar.Maximum = songTitlesList.CheckedItems.Count;
            downloadStatusProgressbar.Value = 0;
            downloadStatusProgressbar.Step = 1;

            convertionStatusProgressbar.Maximum = songTitlesList.CheckedItems.Count;
            convertionStatusProgressbar.Value = 0;
            convertionStatusProgressbar.Step = 1;

            dlManager = new BackgroundWorker();
            dlManager.RunWorkerCompleted += dlManager_RunWorkerCompleted;
            dlManager.DoWork += dlManager_DoWork;
            dlManager.WorkerReportsProgress = true;
            dlManager.ProgressChanged += dlManager_WorkerProgressChanged;

            downloadVideosButton.Text = "Videos are downloading...";
            downloadVideosButton.Enabled = false;
            downloadVideosButton.BackColor = Color.FromArgb(255, 70, 0, 0);

            dlManager.RunWorkerAsync();
         
        }
        private void dlManager_DoWork(object sender, DoWorkEventArgs e)
        {
            bkgdls = new List<BackgroundDownloader>();
            checkedVideos = new List<YouTubeVideo>();
            for (int k = 0; k < songTitlesList.Items.Count; k++)
            {
                if(songTitlesList.GetItemCheckState(k) == CheckState.Checked)
                    checkedVideos.Add(videos[k]);
            }

            int maxDownloads = 2;
            for (nextDownload = 0; nextDownload < maxDownloads; nextDownload++) 
            {
                if (nextDownload >= checkedVideos.Count)
                    break;
                else
                    bkgdls.Add( new BackgroundDownloader(checkedVideos[nextDownload].title, destinationTextBox.Text, "https://www.youtube.com/watch?v=" + checkedVideos[nextDownload].id, downloadStatusProgressbar,dlManager));
            }

            //Mp4ToMp3Converter converter = new Mp4ToMp3Converter(@"C:\Users\FairyMental\Desktop\DownloadTest\01. BAZOOKA - Trotineta cu Trei Roţi (Prod. ECHO).mp4");
            while(bkgdls.Count != 0)
            {
                Task.Delay(250);
            }

        }
        private void dlManager_WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            downloadStatusProgressbar.PerformStep();
            mp4Files.Add(e.UserState.ToString());
            if (!dontConvertCheckbox.Checked)
            {
                Mp4ToMp3Converter converter = new Mp4ToMp3Converter(e.UserState.ToString(), dontDeleteVideoCheckbox.Checked,convertionStatusProgressbar);
            }
            for (int i = 0; i < bkgdls.Count; i++)
            {
                if (bkgdls[i].filePath == mp4Files[mp4Files.Count - 1])
                {
                    bkgdls.RemoveAt(i);
                    if (nextDownload >= checkedVideos.Count)
                        break;
                    else
                    {
                        bkgdls.Add(new BackgroundDownloader(checkedVideos[nextDownload].title, destinationTextBox.Text, "https://www.youtube.com/watch?v=" + checkedVideos[nextDownload++].id, downloadStatusProgressbar, dlManager));
                    }
                    break;
                }

            }
        }
        private void dlManager_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            downloadVideosButton.Text = "Download Videos";
            downloadVideosButton.Enabled = true;
            downloadVideosButton.BackColor = Color.FromArgb(255, 120, 0, 0);
        }

        private void dontRenameCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkboxDoNotRename = dontRenameCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void dontDeleteVideoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkboxDoNotDeleteVideo = dontDeleteVideoCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void dontConvertCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkboxDoNotConvert = dontConvertCheckbox.Checked;
            Properties.Settings.Default.Save();
        }
        private void saveSettings()
        {
            Properties.Settings.Default.Save();
        }

    }
}
