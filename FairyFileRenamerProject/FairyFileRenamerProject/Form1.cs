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

namespace FairyFileRenamerProject
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            
        }
        private void loadSongsButton_Click(object sender, EventArgs e)
        {
            string playListID = "";
            int index = downloadLinkTextBox.Text.LastIndexOf("list=") + 5;
            while(index < downloadLinkTextBox.Text.Length)
            {
                playListID += downloadLinkTextBox.Text[index++];
            }

            YouTubeVideo[] videos = YouTubeApi.GetPlayList(playListID);

            foreach (var video in videos)
            {
                songTitlesList.Items.Add(video.title + " " + video.id);
            }

            /*
            YouTubeVideo video = new YouTubeVideo(downloadLinkTextBox.Text);
            songTitlesList.Items.Add(video.title + " " + video.id);*/
        }
    }
}
