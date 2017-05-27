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
    
        private void downloadVideosButton_Click(object sender, EventArgs e)
        {
            
            downloadStatusProgressbar.Maximum = videos.Length;
            downloadStatusProgressbar.Value = 1;
            downloadStatusProgressbar.Step = 1;

            dlManager = new BackgroundWorker();
            dlManager.RunWorkerCompleted += dlManager_RunWorkerCompleted;
            dlManager.DoWork += dlManager_DoWork;
            dlManager.WorkerReportsProgress = true;
            dlManager.ProgressChanged += dlManager_WorkerProgressChanged;

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

            int maxDownloads = 3;
            for (nextDownload = 0; nextDownload < maxDownloads; nextDownload++) 
            {
                if (nextDownload >= checkedVideos.Count)
                    break;
                else
                    bkgdls.Add(new BackgroundDownloader(destinationTextBox.Text, "https://www.youtube.com/watch?v=" + checkedVideos[nextDownload].id, downloadStatusProgressbar,dlManager));
            }

            //MessageBox.Show("Wait");

            //Mp4ToMp3Converter converter = new Mp4ToMp3Converter(@"C:\Users\FairyMental\Desktop\DownloadTest\01. BAZOOKA - Trotineta cu Trei Roţi (Prod. ECHO).mp4");
            while(bkgdls.Count != 0)
            {
                Task.Delay(250);
            }

        }
        private void dlManager_WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            mp4Files.Add(e.UserState.ToString());
           
            Mp4ToMp3Converter converter = new Mp4ToMp3Converter(e.UserState.ToString());
            for (int i = 0; i < bkgdls.Count; i++)
            {
                if (bkgdls[i].filePath == mp4Files[mp4Files.Count - 1])
                {
                    bkgdls.RemoveAt(i);
                    if (nextDownload >= checkedVideos.Count)
                        break;
                    else
                    {
                        bkgdls.Add(new BackgroundDownloader(destinationTextBox.Text, "https://www.youtube.com/watch?v=" + checkedVideos[nextDownload++].id, downloadStatusProgressbar, dlManager));
                    }
                    
                    break;
                }

            }
        }
        private void dlManager_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
       
    }
}
