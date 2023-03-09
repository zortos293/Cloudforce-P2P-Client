using KeyAuth;
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

namespace CF_P2P
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            KeyAuthApp.init();
            //this.AllowDrop = true;
            //this.DragEnter += new DragEventHandler(Form1_DragEnter);
            //this.DragDrop += new DragEventHandler(Form1_DragDrop);
            
        }
        public static api KeyAuthApp = new api("CF Early", "0t0Sr0pLaB", "c52ed8ebcefc829ffed9a73e9c85b73fd5a8e244abec5531ef1cf87628d181e0", "1.0");

        //void Form1_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        //}

        //void Form1_DragDrop(object sender, DragEventArgs e)
        //{
        //    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //    foreach (string file in files) Console.WriteLine(file);
        //}

        //private void guna2Button2_Click(object sender, EventArgs e)
        //{
        //    KeyAuthApp.setvar("us", guna2TextBox1.Text);
        //}

        //private void guna2Button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(KeyAuthApp.getvar("us"));
        //}

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            KeyAuthApp.login(Username.Text, Password.Text);
            if (!KeyAuthApp.response.success)
            {
                guna2HtmlLabel1.Text = KeyAuthApp.response.message;
            }
            else
            {
              if (Directory.Exists("C:\\asgard"))
              {
                  GFN gFN = new GFN();
                  gFN.Show();
                  this.Close();
              }
              else
              {

              }
            }
        }
    }
}
