namespace WindowsFormsApplication1
{
    partial class Advanced_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFolderTextBox = new MetroFramework.Controls.MetroTextBox();
            this.saveFileButton = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nameSaveFile = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveFolderTextBox);
            this.groupBox1.Controls.Add(this.saveFileButton);
            this.groupBox1.Controls.Add(this.metroCheckBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 132);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save In";
            // 
            // saveFolderTextBox
            // 
            // 
            // 
            // 
            this.saveFolderTextBox.CustomButton.Image = null;
            this.saveFolderTextBox.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.saveFolderTextBox.CustomButton.Name = "";
            this.saveFolderTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.saveFolderTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.saveFolderTextBox.CustomButton.TabIndex = 1;
            this.saveFolderTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.saveFolderTextBox.CustomButton.UseSelectable = true;
            this.saveFolderTextBox.CustomButton.Visible = false;
            this.saveFolderTextBox.Lines = new string[] {
        "(Saves To Default Folder)"};
            this.saveFolderTextBox.Location = new System.Drawing.Point(6, 39);
            this.saveFolderTextBox.MaxLength = 32767;
            this.saveFolderTextBox.Name = "saveFolderTextBox";
            this.saveFolderTextBox.PasswordChar = '\0';
            this.saveFolderTextBox.ReadOnly = true;
            this.saveFolderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.saveFolderTextBox.SelectedText = "";
            this.saveFolderTextBox.SelectionLength = 0;
            this.saveFolderTextBox.SelectionStart = 0;
            this.saveFolderTextBox.ShortcutsEnabled = true;
            this.saveFolderTextBox.Size = new System.Drawing.Size(311, 23);
            this.saveFolderTextBox.TabIndex = 4;
            this.saveFolderTextBox.Text = "(Saves To Default Folder)";
            this.saveFolderTextBox.UseSelectable = true;
            this.saveFolderTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.saveFolderTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(323, 39);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(31, 23);
            this.saveFileButton.TabIndex = 3;
            this.saveFileButton.Text = "...";
            this.saveFileButton.UseSelectable = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(6, 86);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(111, 15);
            this.metroCheckBox1.TabIndex = 1;
            this.metroCheckBox1.Text = "Create Subfolder";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nameSaveFile);
            this.groupBox3.Location = new System.Drawing.Point(7, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 100);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name";
            // 
            // nameSaveFile
            // 
            this.nameSaveFile.Location = new System.Drawing.Point(6, 44);
            this.nameSaveFile.Name = "nameSaveFile";
            this.nameSaveFile.Size = new System.Drawing.Size(345, 20);
            this.nameSaveFile.TabIndex = 1;
            this.nameSaveFile.Text = "(If user wants to rename file)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroCheckBox3);
            this.groupBox4.Controls.Add(this.metroCheckBox2);
            this.groupBox4.Location = new System.Drawing.Point(7, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 113);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Checked = true;
            this.metroCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox3.Location = new System.Drawing.Point(24, 69);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(88, 15);
            this.metroCheckBox3.TabIndex = 1;
            this.metroCheckBox3.Text = "Start Torrent";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(24, 34);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(107, 15);
            this.metroCheckBox2.TabIndex = 0;
            this.metroCheckBox2.Text = "Skip hash check";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // Advanced_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Advanced_Settings";
            this.Resizable = false;
            this.Text = "Advanced Settings";
            this.Load += new System.EventHandler(this.Advanced_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox saveFolderTextBox;
        private MetroFramework.Controls.MetroButton saveFileButton;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nameSaveFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}