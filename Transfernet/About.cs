using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class About : MetroFramework.Forms.MetroForm
    {
        public About()
        {
            InitializeComponent();
            this.Icon = WindowsFormsApplication1.Properties.Resources.icon;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://transfernet.io");
        }
    }
}
