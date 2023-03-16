using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CF_P2P
{
    public partial class GFN : Form
    {
        public GFN()
        {
            InitializeComponent();
        }

        private void GFN_Load(object sender, EventArgs e)
        {

        }
        public string PreviusDownlaod;
        private bool DownloadFinished;
        public void File_Downloader(string URL, string path, string filename)
        {
            // download file with progress bar
            DownloadFinished = false;
            WebClient client = new WebClient();
            
            DownloadProgressbar.Invoke(new MethodInvoker(delegate { DownloadProgressbar.Value = 0; }));
            DownloadProgressbar.Invoke(new MethodInvoker(delegate { DownloadProgressbar.Visible = true; }));
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadChanged);
            client.DownloadFileAsync(new Uri(URL), path);
            DownloadLBL.Invoke(new Action(() => DownloadLBL.Text = "Downloading  " + filename));
            while (DownloadFinished == false)
                Application.DoEvents();
        }

        private async void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                DownloadFinished = true;
                
                DownloadProgressbar.Invoke(new Action(() => DownloadProgressbar.Value = 0));

                ((WebClient)sender).Dispose();
            }
            else
            {
               
                MessageBox.Show(e.Error.Message);
                Login.KeyAuthApp.setvar("Download", "");

            }
        }

        private void DownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgressbar.Invoke(new Action(() => DownloadProgressbar.Value = e.ProgressPercentage));
            
        }


        public async Task ExtractZipFileAsync(string zipFilePath, string extractPath)
        {
            await Task.Run(() => ZipFile.ExtractToDirectory(zipFilePath, extractPath));

        }
        public async Task ExtractZipFileAndWaitAsync(string zipFilePath, string extractPath)
        {
            await ExtractZipFileAsync(zipFilePath, extractPath);
            // The following line of code will only execute after the async extraction is complete.
            
        }
        async void DownloadFile(string username)
        {
            WebClient webClient = new WebClient();
            Login.KeyAuthApp.setvar("Download", "");
            string Filename = webClient.DownloadString("http://node.zortos.me:5050/api/getfilename/" + username);
            File_Downloader("http://node.zortos.me:5050/api/download/" + username, "c:\\ZortosP2P\\" + Filename, Filename);
            DownloadLBL.Text = "Downloaded " + Filename + " to c:\\ZortosP2P\\";
            if (Filename.EndsWith(".zip"))
            {
                await ExtractZipFileAndWaitAsync("C:\\ZortosP2P\\" + PreviusDownlaod, "c:\\ZortosP2P\\");


            }

        }
        
        private void UploadLBL_Click(object sender, EventArgs e)
        {

        }

        private void WaitFile_Tick(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(Login.KeyAuthApp.getvar("Download")))
           {
                DownloadFile(Login.KeyAuthApp.user_data.username);
                

           }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
