using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace TransferNetClient
{
    public partial class Add_Transfernet : MetroFramework.Forms.MetroForm
    {
        public General referenceToTransfernet;

        public Add_Transfernet(string fileName, FileInfo fileSize, string filePath)
        {
            InitializeComponent();
            this.Icon = TransferNetClient.Properties.Resources.icon;
            this.labelName2.Text = fileName;

            this.labelPath.Text = filePath;



        }



        private void Add_Transfernet_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = 0;
            timer1.Start();

            string path = "..\\Debug\\Data\\BlockList.txt";

            string[] allLinesBL = File.ReadAllLines(path);

            var lineCount = File.ReadLines(path).Count();

            //displays the current time and date

            int i = 0;
            var lineNumber = 0;

            //randomize lines that contain user data in .transfernet file
            string[] allLines = File.ReadAllLines(labelPath.Text);
            Random rand = new Random();
            allLines = allLines.OrderBy(line => rand.Next()).ToArray();
            File.WriteAllLines(labelPath.Text, allLines);

            //display a random amount of users
            Random r = new Random();
            int num = r.Next(5, allLines.Length);

            // foreach (string line in File.ReadLines(labelPath.Text))
            while (lineNumber < num)
            {

                string[] subStrings = allLines[lineNumber].Split(',');

                double maxvalue = (double)numericUpDown1.Value;
                string price2str = subStrings[0];
                double priceint = Convert.ToDouble(price2str);

                Panel p = new Panel();
                p.Width = 550;
                p.Height = 20;

                //price
                CheckBox newbox = new CheckBox();
                newbox.Location = new Point(5, 0);
                newbox.Text = subStrings[0];
                newbox.Name = "box" + i.ToString();
                p.Controls.Add(newbox);

                //each row is a panel with the tag set as the price for easy comparison to the max value;
                p.Tag = subStrings[0];


                //name label
                Label lbl = new Label();
                lbl.Location = new Point(0 + 125, 5);
                lbl.Text = subStrings[1];
                p.Controls.Add(lbl);

                //successful transfers
                Label lbl2 = new Label();
                lbl2.Location = new Point(0 + 300, 5);
                lbl2.Text = subStrings[2];
                p.Controls.Add(lbl2);

                flowLayoutPanel1.Controls.Add(p);

                //check if name is in the Blacklist and changes it to red
                for (int j = 0; j < lineCount; ++j)
                {
                    if (allLinesBL[j] == lbl.Text)
                    {
                        newbox.ForeColor = Color.Red;
                        lbl.ForeColor = Color.Red;
                        lbl2.ForeColor = Color.Red;
                        lbl2.Text = "blocked";
                    }
                    //   }
                }


                i++;
                lineNumber++;


            }


            


        }
        #region price_updates
        //broken
        private void price_update()
        {

            //the labels need to update their totals when boxes are being checked

            double avg = 0;
            double total = 0;
            double num = 0;

            //check each panel for the price
            foreach (Panel p in flowLayoutPanel1.Controls)
            {
                Debug.Write(p.Tag);
                foreach (Control c in p.Controls)
                {
                    if ((c is CheckBox) && ((CheckBox)c).Checked)
                    {
                        double value = Convert.ToDouble(c.Text);
                        num = num + 1;
                        total = (total + value);
                        avg = total / num;
                        avg = Math.Round(avg, 2);
                        labelTotal.Text = avg.ToString();
                    }
                    else
                    {

                        labelTotal.Text = avg.ToString();

                    }
                  }

                }
           }
                    



        

        //removes entries that were above the max value
        private void price_maxvalue()
        {

        
           foreach (Control p in flowLayoutPanel1.Controls)
            {

                if (p is Panel)
                {
                    decimal tag = Convert.ToDecimal(p.Tag);
                    if (tag > numericUpDown1.Value)
                    {
                        //add panel to a hidden panel; remove it from the panel that is seen
                        flowLayoutPanel2.Controls.Add(p);
                        flowLayoutPanel1.Controls.Remove(p);
                    }

                    //now check to make sure that any of the previously removed entries don't need to be readded
                    foreach(Control p2 in flowLayoutPanel2.Controls)
                    {
                        decimal tag2 = Convert.ToDecimal(p2.Tag);
                        if (tag2 <= numericUpDown1.Value)
                        {
                            flowLayoutPanel2.Controls.Remove(p2);
                            flowLayoutPanel1.Controls.Add(p2);
                        }
                    }
                }
            }
        
        }

        //readds entries that were removed if the max value changes


        #endregion price_updates


        private void timer1_Tick(object sender, EventArgs e)
        {
            //DateTime datetime = DateTime.Now;

            price_update();
            price_maxvalue();
        }

        #region buttons
        //advance settings
        private void advButton_Click(object sender, EventArgs e)
        {
            Advanced_Settings frm = new Advanced_Settings();
            frm.Show();
        }

        //Cancel
        private void metroButton5_Click(object sender, EventArgs e)
        {
            Add_Transfernet.Purchase = false;
            this.Close();
        }


        //select all
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Checked == false)
                    {
                        cb.Checked = true;
                    }
                }
            }
            price_update();
        }

        //select none
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
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
            price_update();
        }

        //buy

        static bool purchase;

        public static bool Purchase
        {
            get
            {
                return purchase;
            }
            set
            {
                purchase = value;
            }
        }
       

        private void Buy_Click_1(object sender, EventArgs e)
        {
            price_update();
            
            int count = 0;
            //counting to see that at least one box is checked
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Checked == true)
                    {
                        count++;
                    }
                }
            }
            //if no boxes are checked, warning pops up
            if (count == 0)
            {
                MessageBox.Show("No Files Selected. Please select at least one item if you wish to buy.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Add_Transfernet.Purchase = true;
            
                this.Close();
                
            }
            /*
            //if we want a "confirm purchase" message box to appear when the buy button is clicked 
            else
            {
                //if the "Buy" button is clicked and there are selected items, then information on the main page needs to pop up
                var res = MessageBox.Show("Purchase these transfers for a total of $" + metroLabel1.Text, "Finalize Purchase", MessageBoxButtons.YesNo);
                if (res != DialogResult.Yes)
                {
                    return;
                }
                else
                { this.Close(); }

            }\
            */
        }


        #endregion buttons

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
