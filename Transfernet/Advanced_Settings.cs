using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferNetClient
{
    public partial class Advanced_Settings : MetroFramework.Forms.MetroForm
    {
        public Advanced_Settings()
        {
            InitializeComponent();
            this.Icon = TransferNetClient.Properties.Resources.icon;


        }

        private void Advanced_Settings_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
