using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Diagnostics;

namespace TransferNetClient
{

    /*Summary: The Block List contains names of seeders that the user does not trust
     The code creates a text file in the bin that holds all these names and the names will show up even after the application is closed and reopened
    
    */
    public partial class BlockList : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;

        public BlockList()
        {
            InitializeComponent();
            this.Icon = TransferNetClient.Properties.Resources.icon;
        }
        #region Initializing Components
        //Not sure why all the components are being added here when added on the design page
        private void InitializeComponent()
        {
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(23, 73);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.WaterMark = "Enter Username...";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(263, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Enter Username...";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(292, 73);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Block";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Blacklisted Users:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 151);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 239);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // BlockList
            // 
            this.AcceptButton = this.metroButton1;
            this.ClientSize = new System.Drawing.Size(396, 413);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "BlockList";
            this.Resizable = false;
            this.Text = "Blacklist";
            this.Load += new System.EventHandler(this.BlockList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion 
        private void BlockList_Load(object sender, EventArgs e)
        {
            readBlacklist();
        }
        int k = 0;
        string pathCur = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);


        //function to read users from blacklist text
        private void readBlacklist()
        {

            // need to check to see if BlockList.txt file exists
            //if the file doesn't exist, it is created and then needs to be closed
#if DEBUG
            string path = "..\\Debug\\Data\\BlockList.txt";
            
            if (!File.Exists(path))
            {
                Directory.CreateDirectory("..\\Debug\\Data");
                File.Create("..\\Debug\\Data\\BlockList.txt").Close();
            }
#else
            string path = "..\\Release\\Data\\Blocklist.txt";  
            if (!File.Exists(path))
            {
                Directory.CreateDirectory("..\\Release\\Data");
                File.Create("..\\Release\\Data\\BlockList.txt").Close();
            }
#endif

            string[] allLines = File.ReadAllLines(path);

            var lineCount = File.ReadLines(path).Count();

            //this loop reads the blocklist file and then displays the names on the form (inculdes the unblock button)
            //bad things will happen once an unblock feature is added
            //maybe the positon of labels needs to be relative
            for (int j = 0; j < lineCount; ++j)
            {
                Panel p = new Panel();
                p.Width = 350; //same width as the flowlayout
                p.Height = 20; // height of a line of text
                p.Tag = k;
                //label for the user name
                Label lbl = new Label();
                lbl.Text = allLines[j];
                p.Name = lbl.Text;
                p.Controls.Add(lbl);
               
                //unblock button that will be linked to the username
                Button btn = new Button();
                btn.Name = "btn" + j.ToString();
                btn.Text = "Unblock";
                btn.Location = new Point(250, 0);
                p.Controls.Add(btn);
                btn.Tag = k; 

                btn.Click += new EventHandler(button_Click);

                flowLayoutPanel1.Controls.Add(p);
                k++;
            }
        }

        #region button clicks

        //when enter or the block button is pressed, the username is added to the txt file

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(metroTextBox1.Text))
            {
                Panel p = new Panel();
                p.Width = 350; //same width as the flowlayout
                p.Height = 20; // height of a line of text
                p.Tag = k;

                Label lbl = new Label();
                lbl.Text = metroTextBox1.Text;
                p.Controls.Add(lbl);
                metroTextBox1.Text = String.Empty;
                p.Name = lbl.Text;
                

                Button btn = new Button();
                btn.Text = "Unblock";
                btn.Location = new Point(250, 0);
                btn.Tag = k;
                p.Controls.Add(btn);

                flowLayoutPanel1.Controls.Add(p);

                btn.Click += new EventHandler(button_Click);

                k++;


                //append new text to the block list text file
#if DEBUG
                File.AppendAllText("..\\Debug\\Data\\BlockList.txt", lbl.Text + Environment.NewLine);
                
#else
                File.AppendAllText("..\\Release\\Data\\BlockList.txt", lbl.Text + Environment.NewLine);
#endif
            }

            this.Focus();

        }

        //process for removing a name from the list when it's unblock button is pressed
        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //label value is just a placeholder until the foreach loop is ran
            string label = "boop";
            var num = button.Tag;
            double num2 = Convert.ToDouble(num);
            double i = 0;

            
            foreach (Panel p in flowLayoutPanel1.Controls)
            {
                //if the button tag matches the tag of the panel, that panel will be removed
                if (i == num2)
                {
                    flowLayoutPanel1.Controls.Remove(p);
                    Debug.Write("removed the panel");
                    label =  p.Name;
                    break;
                }
                i++;

            }


           //reads all the lines in the BlockList
           string[] lines = File.ReadAllLines("..\\Debug\\Data\\BlockList.txt");
           var count = lines.Length;

            //matches the label with the line in the file with the same user and removes the name from the text file
            for(int h=0; h<=count; h++)
            {
                if(lines[h] == label)
                {
                    string lineToRemove = label;
                    lines = lines.Where(val => val != lineToRemove).ToArray();
                    break;
                }
            }

            //removes the suer from the text file
            File.WriteAllLines("..\\Debug\\Data\\BlockList.txt",lines);





        }

        #endregion button clicks

    }
}
