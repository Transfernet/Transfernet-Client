using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Add_Transfernet : MetroFramework.Forms.MetroForm
    {
        public Add_Transfernet()
        {
            InitializeComponent();
        }

        private void Add_Transfernet_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Transfernet File| *.transfernet";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();

            
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //this is the ok button to save the transfernet file

            
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
