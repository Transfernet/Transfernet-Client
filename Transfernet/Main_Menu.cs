using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;



/*Things that are broken
 * elapsed time when downloading / estimated time
 * download in progress doesn't change to download complete when the progress bar is filled
 * buttons remain highlighted after you click on one
 */


namespace TransferNetClient
{
    public partial class General : MetroFramework.Forms.MetroForm
    {
        #region basics 
        public General()
        {
            InitializeComponent();
            this.Icon = TransferNetClient.Properties.Resources.icon;
        }

        #region backgroundworker

        private void checkStatus()
        {
            //need a way to queue multiple downloads
            //don't start download if one is still in progress

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
            



            for (int k = 0; k <= progressBar1.Maximum; k++)
            {
                // Report progress to 'UI' thread
                backgroundWorker1.ReportProgress(k);
                // Simulate long task for .1 seconds
                Thread.Sleep(100);


            }


            
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            //small progress bar in top panel... BROKEN does not update with large progressbar
            //commenting out this progress bar for now
            ProgressBar pBar = new ProgressBar();
            pBar.Location = new Point(445, 0 + (25 * (count - 1)));
            pBar.Width = 100;
            pBar.Height = 15;
            pBar.Maximum = 100;
            //metroPanel1.Controls.Add(pBar);

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
            //trying to figure out how to recustomize the button to not have a 'highlighted' state but did not work
            this.transferButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

        }
        #endregion basics

        #region AddTransfernetFile

        //need to store the info from the recently opened file
        public string filename;
        public string size;
        public string path;

        //there are two ways to add a transfernet file: from the menu strip or button on menu
        private void addTorrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Downloads";
            openFileDialog1.Filter = "content files (*.content)|*.content|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                FileInfo filesize = new FileInfo(openFileDialog1.FileName);

                size = filesize.Length.ToString();
                filename = openFileDialog1.SafeFileName;
                path = openFileDialog1.FileName;

                Add_Transfernet frm = new Add_Transfernet(openFileDialog1.SafeFileName, filesize, openFileDialog1.FileName);
                frm.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);

                frm.ShowDialog();


            }

           
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
                addPeers();
                
            }

            else
            {
                // Then assume that "Close" has been clicked and add nothing.
            }

        }



        public int j = 1;

        #endregion AddTransfernetFile

        #region update_sync
        public void update()
        {
           
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            count++;

            tabControl1.SelectedTab = tabPage2;


            //none of these labels appear yet because these variables have been deleted somewhere along the way

            
            Panel p = new Panel();
            p.Width = 850;
            p.Height = 20;

            //lable for num
            Label num = new Label();
            num.AutoSize = true;
            num.Location = new Point(0,0);
            num.Text = count.ToString();
            p.Controls.Add(num);

            //label for name
            Label name = new Label();
            name.AutoSize = true;
            name.Location = new Point(70, 0);
            name.Text = filename;
            p.Controls.Add(name);

            //label for size
            Label siz = new Label();
            siz.AutoSize = true;
            siz.Location = new Point(355, 0);
            siz.Text = size;
            p.Controls.Add(siz);

            //label for progress instead of bar because 2 background workers was messing up a lot of things
            Label prog = new Label();
            prog.AutoSize = true;
            prog.Location = new Point(435, 0);
            prog.Text = "Download in Progress";
            p.Controls.Add(prog);

            flowLayoutPanel1.Controls.Add(p);



            //labels for tab pages
            Label file = new Label();
            file.AutoSize = true;
            file.Text = num.Text + " " + filename;
            file.Location = new Point(0, 0 + (25 * (count-1)));
            metroPanel2.Controls.Add(file);

            this.Focus();
        }

        private void addPeers()
        {
           

            int i = 0;
            var lineNumber = 0;
            string resName = Properties.Resources.Peers;


            //randomize lines that contain user data in .transfernet file

            string[] allLines = resName.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            Random rand = new Random();
            allLines = allLines.OrderBy(line => rand.Next()).ToArray();
            

            //display a random amount of users
            Random r = new Random();
            int num = r.Next(10, allLines.Length);

            // foreach (string line in File.ReadLines(labelPath.Text))
            while (lineNumber < num)
            {

                string[] subStrings = allLines[lineNumber].Split(',');
                

                Label lbl5 = new Label();
                lbl5.Location = new Point(5, 0 + (25 * i));
                lbl5.Text = subStrings[0];
                metroPanel3.Controls.Add(lbl5);

                Label lbl2 = new Label();
                lbl2.Location = new Point(225, 0 + (25 * i));
                lbl2.Text = subStrings[1];
                metroPanel3.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Location = new Point(400, 0 + (25 * i));
                lbl3.Text = subStrings[2];
                metroPanel3.Controls.Add(lbl3);
                
                i++;
                lineNumber++;
            }
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
            frm.ShowDialog();
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
            frm.ShowDialog();
        }

        #endregion HelpMenu

        #region ButtonMenu
        private void seedButton_Click(object sender, EventArgs e)
        {
            Seeding frm = new Seeding();
            frm.ShowDialog();
        }


        #endregion ButtonMenu


        #region BlackList

        private void blockButton_Click(object sender, EventArgs e)
        {
            Form frm = new BlockList();
            frm.ShowDialog();

            
        }

		#endregion  BlackList

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}