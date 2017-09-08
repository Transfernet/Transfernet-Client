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
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


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

        private void advButton_Click(object sender, EventArgs e)
        {
            Advanced_Settings frm = new Advanced_Settings();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.displayTime.Text = datetime.ToString();
        }

        private void displayTime_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach(Control c in groupBoxBuy.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if(cb.Checked==false)
                    {
                        cb.Checked = true;
                    }
                }
            }
        }

        private void selectNoneButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBoxBuy.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Checked == true)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }
    }
}
