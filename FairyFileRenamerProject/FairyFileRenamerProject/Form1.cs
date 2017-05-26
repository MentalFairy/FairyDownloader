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

            BackgroundWorker dlManager = new BackgroundWorker();
            dlManager.RunWorkerCompleted += dlManager_RunWorkerCompleted;
            dlManager.DoWork += dlManager_DoWork;
            dlManager.RunWorkerAsync();

         
         
        }
        private void dlManager_DoWork(object sender, DoWorkEventArgs e)
        {
            List<BackgroundDownloader> bkgdls = new List<BackgroundDownloader>();
            List<YouTubeVideo> checkedVideos = new List<YouTubeVideo>();
            for (int k = 0; k < songTitlesList.Items.Count; k++)
            {
                if(songTitlesList.GetItemCheckState(k) == CheckState.Checked)
                    checkedVideos.Add(videos[k]);
            }

            int maxDownloads = 3;
            int currentDownloads = 0;
            int i = 0;
            while(i < checkedVideos.Count)
            {
                if (currentDownloads < maxDownloads)
                {
                    bkgdls.Add(new BackgroundDownloader(destinationTextBox.Text, "https://www.youtube.com/watch?v=" + checkedVideos[i].id, downloadStatusProgressbar));
                    currentDownloads++;
                }
                else
                {
                    i--;
                    int j = 0;
                    int deletePos = -1;
                    foreach (var bkgdownloader in bkgdls)
                    {   
                        if (bkgdownloader.finished == true)
                        {
                            deletePos = j;
                            currentDownloads--;
                            break;
                        }
                        j++;
                    }
                    if(deletePos != -1)
                        bkgdls.RemoveAt(deletePos);
                }
                i++;

            }
            MessageBox.Show("Done downloading");
        }
        private void dlManager_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //
        }
       
    }
}
