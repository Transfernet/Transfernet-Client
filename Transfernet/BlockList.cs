using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApplication1
{

    //Block List needs to be able to remember the entires when it is pulled up next
    //possibly have the list exported to a text file and when loading the form it loads the file
    public partial class BlockList : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Panel panel1;

        public BlockList()
        {
            InitializeComponent();
            this.Icon = WindowsFormsApplication1.Properties.Resources.icon;
        }

        private void InitializeComponent()
        {
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(148, 1);
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
            this.metroTextBox1.PromptText = "Enter Username...";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(170, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Enter Username...";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(199, 73);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Block";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(23, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 137);
            this.panel1.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "List of Blocked Users:";
            // 
            // BlockList
            // 
            this.AcceptButton = this.metroButton1;
            this.ClientSize = new System.Drawing.Size(297, 308);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "BlockList";
            this.Resizable = false;
            this.Text = "Block List";
            this.Load += new System.EventHandler(this.BlockList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BlockList_Load(object sender, EventArgs e)
        {

        }

        int i=0;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(metroTextBox1.Text))
            {
                // do nothing
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = metroTextBox1.Text;
                lbl.Location = new Point(0, (0 +(25* i)));
                panel1.Controls.Add(lbl);
                metroTextBox1.Text = String.Empty;
                i++;
                
            }
        }
    }
}
