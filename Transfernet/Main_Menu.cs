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
    public partial class Transfernet : MetroFramework.Forms.MetroForm
    {
        public Transfernet()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1_Run();
        }

        

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
            metroProgressBar2.Value = e.ProgressPercentage;
            metroProgressBar3.Value = e.ProgressPercentage;
            metroProgressBar4.Value = e.ProgressPercentage;
        }

        public void backgroundWorker1_Run()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

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

                //tabFiles.Controls.Add(new Label());
                //filesName.Text = openFileDialog1.SafeFileName
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
    }
}
