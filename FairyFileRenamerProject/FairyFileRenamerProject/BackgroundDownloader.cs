using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using YoutubeExtractor;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FairyFileRenamerProject
{
    class BackgroundDownloader
    {
        BackgroundWorker worker = new BackgroundWorker();
        BackgroundWorker bkgdls;

        IEnumerable<VideoInfo> videoInfos;
        string destionationPath;
        string videoLink;

        public string filePath = "";

        public bool finished = false;

        ProgressBar progressBar;
        double progress = 0;


        public BackgroundDownloader( string _Path, string _videoURL, ProgressBar _progressBar, BackgroundWorker _bkgdls)
        {
            destionationPath = _Path;
            videoLink = _videoURL;
            progressBar = _progressBar;
            finished = false;

            bkgdls = _bkgdls;

            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();

        }
        
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bkgdls.ReportProgress(0, filePath);
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            videoInfos = DownloadUrlResolver.GetDownloadUrls(videoLink, false);
            DownloadVideo(videoInfos);
        }
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //
        }
        private void DownloadVideo(IEnumerable<VideoInfo> videoInfos)
        {

            try
            {
                VideoInfo video = videoInfos
                    .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                var videoDownloader = new VideoDownloader(video, Path.Combine(destionationPath, RemoveIllegalPathCharacters(video.Title) + video.VideoExtension));
                filePath = Path.Combine(destionationPath, RemoveIllegalPathCharacters(video.Title) + video.VideoExtension);
                videoDownloader.DownloadProgressChanged += (sender, args) => worker.ReportProgress((int)(args.ProgressPercentage));
                videoDownloader.Execute();
            }
            catch(Exception ex)
            {
                //
            }

        }
        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }
    }
}
