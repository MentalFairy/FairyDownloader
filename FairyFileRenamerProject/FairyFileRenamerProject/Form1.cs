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


        private static void DownloadAudio(IEnumerable<VideoInfo> videoInfos)
        {
            /*
             * We want the first extractable video with the highest audio quality.
             */
            VideoInfo video = videoInfos
                .Where(info => info.CanExtractAudio)
                .OrderByDescending(info => info.AudioBitrate)
                .First();

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the audio downloader.
             * The first argument is the video where the audio should be extracted from.
             * The second argument is the path to save the audio file.
             */

            var audioDownloader = new AudioDownloader(video,
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                RemoveIllegalPathCharacters(video.Title) + video.AudioExtension));

            // Register the progress events. We treat the download progress as 85% of the progress
            // and the extraction progress only as 15% of the progress, because the download will
            // take much longer than the audio extraction.
            audioDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage * 0.85);
            audioDownloader.AudioExtractionProgressChanged += (sender, args) => Console.WriteLine(85 + args.ProgressPercentage * 0.15);

            /*
             * Execute the audio downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            audioDownloader.Execute();
        }

        private static void DownloadVideo(IEnumerable<VideoInfo> videoInfos)
        {
            /*
             * Select the first .mp4 video with 360p resolution
             */
            VideoInfo video = videoInfos
                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the video downloader.
             * The first argument is the video to download.
             * The second argument is the path to save the video file.
             */
            var videoDownloader = new VideoDownloader(video,
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                RemoveIllegalPathCharacters(video.Title) + video.VideoExtension));

            // Register the ProgressChanged event and print the current progress
            videoDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);

            /*
             * Execute the video downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            videoDownloader.Execute();
        }
        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }


        private void downloadVideosButton_Click(object sender, EventArgs e)
        {
            downloadStatusProgressbar.Maximum = videos.Length;
            downloadStatusProgressbar.Value = 1;
            downloadStatusProgressbar.Step = 1;
            foreach (var video in videos)
            {
                MessageBox.Show("https://www.youtube.com/watch?v=" + video.id);
                IEnumerable <VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls("https://www.youtube.com/watch?v=" + video.id, false);

                //DownloadAudio(videoInfos);
                DownloadVideo(videoInfos);
                downloadStatusProgressbar.PerformStep();
                MessageBox.Show("WAIT");
            }
        }
    }
}
