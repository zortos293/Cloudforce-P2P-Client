using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CF_P2P
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                FileStream fileToUpload = File.OpenRead(file);
                //HttpContent content = new StreamContent(fileToUpload);
                var content = new MultipartFormDataContent
                {
                     { new StreamContent(fileToUpload), "file", Path.GetFileName(file) }
                };
                HttpRequestMessage msg = new HttpRequestMessage
                {
                    Content = content,
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("http://node.zortos.me:5050/api/upload/"+ Login.KeyAuthApp.user_data.username)
                };
                
                HttpClient httpClient = new HttpClient();
                
                bool keepTracking = true; //to start and stop the tracking thread
                UploadProgressbar.Visible = true;
                new Task(new Action(() => { progressTracker(fileToUpload, ref keepTracking); })).Start();
                var result = httpClient.SendAsync(msg).Result;
                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show("FILE TOO BIG\nCant transfer big files for now ;)");
                }
                keepTracking = false; //stops the tracking thread
                UploadProgressbar.Visible = false;
                UploadProgressbar.Value = 0;
                Login.KeyAuthApp.setvar("Download", "Done");
            }
            

           
        }

        void progressTracker(FileStream streamToTrack, ref bool keepTracking)
        {
            int prevPos = -1;
                while (keepTracking)
                {
                    try
                    {
                        int pos = (int)Math.Round(100 * (streamToTrack.Position / (double)streamToTrack.Length));
                        if (pos != prevPos)
                        {
                            UploadLBL.Text = "Uploading " + prevPos + "%";
                            UploadProgressbar.Value = pos;

                        }
                        prevPos = pos;
                    }
                    catch (Exception e)
                    {
                         keepTracking = false;
                    }

                    //update every 100ms
                    // fix bug
                }

           
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
