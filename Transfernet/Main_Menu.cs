﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class General : MetroFramework.Forms.MetroForm
    {
        #region basics 
        public General()
        {
            InitializeComponent();
            this.Icon = WindowsFormsApplication1.Properties.Resources.icon;
        }

        #region backgroundworker

        private void checkStatus()
        {

        }

        static bool done;

        public static bool Done
        {
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            General.Done = false;


            for (int k = 0; k <= progressBar1.Maximum; k++)
            {
                // Report progress to 'UI' thread
                backgroundWorker1.ReportProgress(k);
                // Simulate long task
                Thread.Sleep(100);
            }
            
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar pBar = new ProgressBar();
            pBar.Location = new Point(445, 0 + (25 * (count - 1)));
            pBar.Width = 100;
            pBar.Height = 15;
            pBar.Maximum = 100;
            metroPanel1.Controls.Add(pBar);

            // The progress percentage is a property of e
            pBar.Value = e.ProgressPercentage;
            progressBar1.Value = e.ProgressPercentage;
            metroLabel9.Text = e.ProgressPercentage.ToString() + "%";
            metroLabel10.Text = "Downloading";


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
            metroLabel10.Text = "Download Complete";
            General.Done = true;

        }


        #endregion backgroundworker 


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        #endregion basics

        #region AddTransfernet

        //need to store the info from the recently opened file
        public string filename;
        public string size;
        public string path;

        //there are two ways to add a transfernet file: from the menu strip or button on menu
        private void addTorrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Downloads";
            openFileDialog1.Filter = "transfernet files (*.transfernet)|*.transfernet|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                var filesize = new FileInfo(openFileDialog1.FileName).Length;

                size = filesize.ToString();
                filename = openFileDialog1.SafeFileName;
                path = openFileDialog1.FileName;

                Add_Transfernet frm = new Add_Transfernet(openFileDialog1.SafeFileName, filesize.ToString(), openFileDialog1.FileName);
                frm.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);

                frm.Show();

                richTextBox2.SelectionTabs = new int[] { 100, 200, 300, 400 };
                richTextBox2.Width = 580;
                richTextBox2.Text =
                    "24,34\t1228\tC:\\14035/61439\tD:\\399175/415186\t01 02 03 04 05 06 07 08 09 10 11\t0 1 2 3 " +
                    "58,05\t4017\tC:\\5610/61439\tD:\\396629/415186\t10 11 12 13 14 15\t0 1 2";
                richTextBox2.SelectAll();
                richTextBox2.SelectionTabs = new int[] { 50, 100, 200, 320, 530 };
                richTextBox2.AcceptsTab = true;
                richTextBox2.Select(0, 0);

            }

            Console.WriteLine(result); // <-- For debugging use.
        }



        //
        public int count = 0;
        public void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool y = Add_Transfernet.Purchase;
            if (y == true)
            //if (e.CloseReason == CloseReason.UserClosing)
           // if (string.Equals((sender as Button).Name, @"buyButton"))
            {
                
                update();
                
            }

            else
            {
                // Then assume that "Close" has been clicked and add nothing.
            }

        }



        public int j = 1;

        private void transferButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Downloads";
            openFileDialog1.Filter = "transfernet files (*.transfernet)|*.transfernet|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                var filesize = new FileInfo(openFileDialog1.FileName).Length;
                Add_Transfernet frm = new Add_Transfernet(openFileDialog1.SafeFileName, filesize.ToString(), openFileDialog1.FileName);
                frm.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);

                frm.Show();

                size = filesize.ToString();
                filename = openFileDialog1.SafeFileName;
                path = openFileDialog1.FileName;

                //each time a new transfernet file is added a new label needs to be added to the tabs and not overwrite the previous files added
                //This section is a work in progress to adjust the label poition based on how many transfers have been added

                //when a transfernet file is added, the savefilename is displayed in the files control box


                j++;
            }
        }

        #endregion AddTransfernet

        #region update_sync
        public void update()
        {
           
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();


            count++;

            tabControl1.SelectedTab = tabPage2;
            

            //location inside metro panel is independent of panel's location on the form
            //lable for num
            Label num = new Label();
            num.AutoSize = true;
            num.Location = new Point(0,0+(25*(count-1)));
            num.Text = count.ToString();
            metroPanel1.Controls.Add(num);

            //label for name
            Label name = new Label();
            name.AutoSize = true;
            name.Location = new Point(70, 0 + (25 * (count-1)));
            name.Text = filename;
            metroPanel1.Controls.Add(name);

            //label for size
            Label siz = new Label();
            siz.AutoSize = true;
            siz.Location = new Point(355, 0 + (25 * (count-1)));
            siz.Text = size;
            metroPanel1.Controls.Add(siz);

            //progerssbar does not update with main progress bar





            if (General.Done == true)
                {
                    stopWatch.Stop();
                   // metroLabel8.Text = elapsedTime.ToString();

                }
            


            //labels for tab pages
            Label file = new Label();
            file.AutoSize = true;
            file.Text = num.Text + " " + filename;
            file.Location = new Point(0, 0 + (25 * (count-1)));
            metroPanel2.Controls.Add(file);


        }
        #endregion update_sync

        #region exit

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)

        {
            this.Close();
        }
        #endregion exit

        #region HelpMenu

        private void releaseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/transfernet");
        }

        private void aboutTransfernetClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/transfernet");
        }

        private void webpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://transfernet.io");
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updates frm = new Updates();
            frm.Show();
        }

        #endregion HelpMenu

        #region ButtonMenu
        private void seedButton_Click(object sender, EventArgs e)
        {
            Seeding frm = new Seeding();
            frm.Show();
        }

        #endregion ButtonMenu


    }
}