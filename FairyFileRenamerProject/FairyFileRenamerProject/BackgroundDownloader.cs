using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using YoutubeExtractor;
using System.IO;
using System.Windows.Forms;

namespace FairyFileRenamerProject
{
    class BackgroundDownloader
    {
        BackgroundWorker worker = new BackgroundWorker();

        IEnumerable<VideoInfo> videoInfos;
        string destionationPath;
        string videoLink;

        ProgressBar progressBar;
        double progress = 0;


        public BackgroundDownloader(string _Path, string _videoURL, ProgressBar _progressBar)
        {
            destionationPath = _Path;
            videoLink = _videoURL;
            progressBar = _progressBar;

            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();

        }
        
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.PerformStep();
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            videoInfos = DownloadUrlResolver.GetDownloadUrls(videoLink, false);
            DownloadVideo(videoInfos);
        }
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }
        private void DownloadVideo(IEnumerable<VideoInfo> videoInfos)
        {

            VideoInfo video = videoInfos
                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            var videoDownloader = new VideoDownloader(video, destionationPath);
            videoDownloader.DownloadProgressChanged += (sender, args) => worker.ReportProgress((int)(args.ProgressPercentage));
            videoDownloader.Execute();

        }
    }
}
