﻿using System;
using System.Drawing;
using System.IO;
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

            //you shouldnt have to run background workers until a tnet file is actually uploaded
            //backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            //backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            //backgroundWorker1.WorkerReportsProgress = true;
            //backgroundWorker1.RunWorkerAsync();

            //what is this timer for?
            //timer
            timer1.Tick += new EventHandler(timer1_Tick); // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (1000) * (1);              // Timer will tick every second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();                              // Start the timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //want to only display seconds for the "Time Elapsed" label in the info tab
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                //this was commented out because it is blocking selection of tabs
                //Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(i);
            }
            //There is a threading problem here.  If you have a background worker you need to make sure it only
            //issues commands to GUI elements while it is running on the main thread

            //you need to use a delegate to run a function from the background thread so it can access the main thread
            // metroLabel31.Show();
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            //metroProgressBar1.Value = e.ProgressPercentage;
            //metroProgressBar2.Value = e.ProgressPercentage;
            //metroProgressBar3.Value = e.ProgressPercentage;
            //row1Progress.Value = e.ProgressPercentage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        #endregion basics

        #region AddTransfernet

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
                var size = new FileInfo(openFileDialog1.FileName).Length;
                Add_Transfernet frm = new Add_Transfernet(openFileDialog1.SafeFileName, size.ToString(), openFileDialog1.FileName);

                frm.Show();

                //when a transfernet file is added, the savefilename is displayed in the files control box

                //need to make it so that this does not show up until the user has confirmed
                //that they want to "buy" the tnet file
                //tabControl1.Controls.Add(new Label());
                metroLabel1.Text = openFileDialog1.SafeFileName;
                row1Name.Text = openFileDialog1.SafeFileName;
                row1Size.Text = size.ToString();
                row1Name.Visible = true;
                row1Size.Visible = true;
            }

            Console.WriteLine(result); // <-- For debugging use.
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
                var size = new FileInfo(openFileDialog1.FileName).Length;
                Add_Transfernet frm = new Add_Transfernet(openFileDialog1.SafeFileName, size.ToString(), openFileDialog1.FileName);

                frm.Show();

                //each time a new transfernet file is added a new label needs to be added to the tabs and not overwrite the previous files added
                //This section is a work in progress to adjust the label poition based on how many transfers have been added

                //when a transfernet file is added, the savefilename is displayed in the files control box
                var file = new Label();
                file.Text = openFileDialog1.SafeFileName;
                file.Location = new Point(tabPage1.Location.X + 10, tabPage1.Location.Y + 1 * j);
                tabPage1.Controls.Add(file);
                row1Name.Text = openFileDialog1.SafeFileName;
                row1Size.Text = size.ToString();
                row1Name.Visible = true;
                row1Size.Visible = true;

                j++;
            }
        }

        #endregion AddTransfernet

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