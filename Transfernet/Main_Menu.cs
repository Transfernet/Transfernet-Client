using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class General : MetroFramework.Forms.MetroForm
    {
        public General()
        {
            InitializeComponent();
            this.Icon = WindowsFormsApplication1.Properties.Resources.icon;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();

            //timer
            timer1.Tick += new EventHandler(timer1_Tick); // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (1000) * (1);              // Timer will tick every second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();                              // Start the timer

        }
          void timer1_Tick(object sender, EventArgs e)
         {
            //want to only display seconds
            metroLabel25.Text = DateTime.Now.ToShortTimeString();
        }




        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(i);
            }
            //There is a threading problem here.  If you have a background worker you need to make sure it only
            //issues commands to GUI elements while it is running on the main thread 
            metroLabel31.Show();
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
            metroProgressBar2.Value = e.ProgressPercentage;
            metroProgressBar3.Value = e.ProgressPercentage;
            metroProgressBar4.Value = e.ProgressPercentage;
        }





        private void Form1_Load(object sender, EventArgs e)
        {

            this.timer1.Start();
            metroLabel31.Hide();
    
        }

        private void addTorrentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Downloads" ;
            openFileDialog1.Filter = "transfernet files (*.transfernet)|*.transfernet|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            


            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                var size = new FileInfo(openFileDialog1.FileName).Length;
                Add_Transfernet frm = new Add_Transfernet(openFileDialog1.SafeFileName, size.ToString());

                frm.Show();
                
                //when a transfernet file is added, the savefilename is displayed in the files control box

                tabFiles.Controls.Add(new Label());
                filesName.Text = openFileDialog1.SafeFileName;
            }

            Console.WriteLine(result); // <-- For debugging use.

        }


    

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressBar4_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void releaseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("https://github.com/Transfernet");

        }

        private void aboutTransfernetClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }
    }
}
