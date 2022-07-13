using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;

namespace d
{
    public partial class warring : Form
    {
        //string d = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public warring()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("this program is no joke do u want to run it? ", "Kira.exe", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    Application.Exit();
                    this.Close();
                }
                else
                {
                    error();
                }
            }catch (Exception ex) { }
            //pre view// i make a new payload screen melter ultra melter in c#k
            

        }
        public void error()
        {
            try
            {
                if (MessageBox.Show("THIS IS WAST WARRING, DO U WANT TO RUN THIS APP???", "Kira.exe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    Application.Exit();
                    this.Close();
                }
                else
                {
                    virus();

                }
            }
            catch { }
            
        }//no
        public void virus()
        {
            //WebClient w = new WebClient();
            //w.DownloadFile("https://www.mediafire.com/file/nsv36sc8cjdoj2r/crazysound7.wav/file", @"C:\sound.wav");
            this.Hide();
            Virus v = new Virus();
            v.Show();
        }

    }
}
