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
        string title;

        public string filePath = "";

        public bool finished = false;
        VideoInfo video;

        ProgressBar progressBar;

        int attempt = 0;

        public BackgroundDownloader(string _title, string _Path, string _videoURL, ProgressBar _progressBar, BackgroundWorker _bkgdls)
        {
            destionationPath = _Path;
            videoLink = _videoURL;
            progressBar = _progressBar;
            finished = false;
            title = _title;
            
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
                if (attempt == 0)
                {
                    video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);
                }
                else if (attempt == 1)
                {
                    video = videoInfos.First(info => info.VideoType == VideoType.Flash && info.Resolution == 360);

                }
                else if (attempt == 2)
                {
                    video = videoInfos.First(info => info.VideoType == VideoType.Mobile && info.Resolution == 360);
                }
                else if (attempt == 3)
                {
                    video = videoInfos.First(info => info.VideoType == VideoType.WebM && info.Resolution == 360);
                }
                else if (attempt == 4)
                {
                    video = videoInfos.First(info => info.VideoType == VideoType.Unknown && info.Resolution == 360);
                }

                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                var videoDownloader = new VideoDownloader(video, Path.Combine(destionationPath, RemoveIllegalPathCharacters(video.Title) + video.VideoExtension));
                filePath = Path.Combine(destionationPath, RemoveIllegalPathCharacters(video.Title) + video.VideoExtension);
                videoDownloader.DownloadProgressChanged += (sender, args) => worker.ReportProgress((int)(args.ProgressPercentage));
                videoDownloader.Execute();
            }
            catch (Exception ex)
            {
                if (attempt < 5)
                {
                    
                  //  MessageBox.Show(attempt + ": " + video.VideoType + " " + video.VideoExtension + ex.Message);
                    attempt++;
                    DownloadVideo(videoInfos);
                }
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
