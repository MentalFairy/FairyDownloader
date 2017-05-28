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
using NYoutubeDL;
using System.Diagnostics;
using NYoutubeDL.Helpers;

namespace FairyFileRenamerProject
{
    class BackgroundDownloader
    {
        BackgroundWorker worker = new BackgroundWorker();
        BackgroundWorker bkgdls;
        
        string destionationPath;
        string videoLink;

        public string filePath = "";
        public string youtubeDLpath;

        public bool finished = false;

        ProgressBar progressBar;


        public BackgroundDownloader( string _Path, string _videoURL, ProgressBar _progressBar, BackgroundWorker _bkgdls)
        {
            destionationPath = _Path;
            videoLink = _videoURL;
            progressBar = _progressBar;
            finished = false;

            bkgdls = _bkgdls;

            youtubeDLpath = Environment.CurrentDirectory + "\\youtube-dl.exe";

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
            YoutubeDL youtubeDL = new YoutubeDL();
            //  MessageBox.Show(youtubeDL.Options.FilesystemOptions.Output);
            
            youtubeDL.Options.FilesystemOptions.Output = destionationPath;
            youtubeDL.Options.PostProcessingOptions.ExtractAudio = false;
            youtubeDL.VideoUrl = videoLink;

            youtubeDL.Options.DownloadOptions.FragmentRetries = -1;
            youtubeDL.Options.DownloadOptions.Retries = -1;
            youtubeDL.Options.VideoFormatOptions.Format = Enums.VideoFormat.mp4;
            youtubeDL.Options.PostProcessingOptions.AudioFormat = Enums.AudioFormat.mp3;
            youtubeDL.Options.PostProcessingOptions.AudioQuality = "0";

         //   MessageBox.Show(youtubeDL.Options.VideoFormatOptions.Format + " \n " + youtubeDL.Options.VideoFormatOptions.MergeOutputFormat);

    //        youtubeDL.StandardOutputEvent += (thissender, output) => MessageBox.Show(output);
            youtubeDL.StandardErrorEvent += (thissender, errorOutput) => MessageBox.Show(errorOutput);

            MessageBox.Show(youtubeDL.Options.FilesystemOptions.Output);

            youtubeDL.Options.GeneralOptions.Update = true;
            youtubeDL.YoutubeDlPath = youtubeDLpath;

            youtubeDL.PrepareDownload();
            Process ydlDownloadProcess = youtubeDL.Download();
            ydlDownloadProcess.StartInfo.UseShellExecute = true;
            
            ydlDownloadProcess.StartInfo.Verb = "runas";
            ydlDownloadProcess.Start();

            

            try
            {
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //
        }
        
        
    }
}
