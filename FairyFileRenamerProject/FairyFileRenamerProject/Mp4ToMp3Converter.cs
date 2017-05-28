
using Frapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairyFileRenamerProject
{
    class Mp4ToMp3Converter
    {
        string inputFile;
        string outputFile;

        string pathToffmpeg;
        
        bool dontDeleteVideoAfter = false;

        BackgroundWorker worker = new BackgroundWorker();

        ProgressBar convertionStatusProgressBar;

        public Mp4ToMp3Converter(string _inputFile,bool _dontDeleteVideoAfter, ProgressBar _convertionStatusProgressBar)
        {
            inputFile = _inputFile;
            outputFile = inputFile.Substring(0, inputFile.Length - 1) + "3";

            dontDeleteVideoAfter = _dontDeleteVideoAfter;
            convertionStatusProgressBar = _convertionStatusProgressBar;

            pathToffmpeg = Environment.CurrentDirectory +"\\ffmpeg.exe";

         //   MessageBox.Show(inputFile + "\n" + outputFile + "\n" + pathToffmpeg);

            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.DoWork += worker_DoWork;
            worker.RunWorkerAsync();
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {

            FFMPEG ffmpeg = new FFMPEG(pathToffmpeg);
            string result2 = ffmpeg.RunCommand("-i \"" + inputFile + "\" -vn -f mp3 -ab 192k \"" + outputFile + "\"");
            if(!dontDeleteVideoAfter)
                File.Delete(inputFile);
            
        }
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            convertionStatusProgressBar.PerformStep();
        }
    }
}
