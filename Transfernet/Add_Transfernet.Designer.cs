namespace WindowsFormsApplication1
{
    partial class Add_Transfernet
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.selectAllButton = new MetroFramework.Controls.MetroButton();
            this.selectNoneButton = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSize = new MetroFramework.Controls.MetroLabel();
            this.labelName2 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxBuy = new System.Windows.Forms.GroupBox();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox8 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.displayTime = new MetroFramework.Controls.MetroLabel();
            this.Buy = new MetroFramework.Controls.MetroButton();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.advButton = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2.SuspendLayout();
            this.groupBoxBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Name:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Size:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 133);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Date:";
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(379, 201);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(75, 23);
            this.selectAllButton.TabIndex = 8;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseSelectable = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // selectNoneButton
            // 
            this.selectNoneButton.Location = new System.Drawing.Point(467, 201);
            this.selectNoneButton.Name = "selectNoneButton";
            this.selectNoneButton.Size = new System.Drawing.Size(75, 23);
            this.selectNoneButton.TabIndex = 9;
            this.selectNoneButton.Text = "Select None";
            this.selectNoneButton.UseSelectable = true;
            this.selectNoneButton.Click += new System.EventHandler(this.selectNoneButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSize);
            this.groupBox2.Controls.Add(this.labelName2);
            this.groupBox2.Controls.Add(this.groupBoxBuy);
            this.groupBox2.Controls.Add(this.displayTime);
            this.groupBox2.Controls.Add(this.selectNoneButton);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.selectAllButton);
            this.groupBox2.Location = new System.Drawing.Point(10, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 465);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contents";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(80, 100);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(100, 19);
            this.labelSize.TabIndex = 33;
            this.labelSize.Text = "Added File Size";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(80, 60);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(113, 19);
            this.labelName2.TabIndex = 32;
            this.labelName2.Text = "Added File Name";
            // 
            // groupBoxBuy
            // 
            this.groupBoxBuy.Controls.Add(this.labelName);
            this.groupBoxBuy.Controls.Add(this.metroLabel8);
            this.groupBoxBuy.Controls.Add(this.metroLabel7);
            this.groupBoxBuy.Controls.Add(this.metroLabel6);
            this.groupBoxBuy.Controls.Add(this.metroLabel9);
            this.groupBoxBuy.Controls.Add(this.metroLabel2);
            this.groupBoxBuy.Controls.Add(this.metroLabel1);
            this.groupBoxBuy.Controls.Add(this.metroCheckBox8);
            this.groupBoxBuy.Controls.Add(this.metroCheckBox7);
            this.groupBoxBuy.Controls.Add(this.metroCheckBox6);
            this.groupBoxBuy.Controls.Add(this.metroCheckBox5);
            this.groupBoxBuy.Controls.Add(this.metroCheckBox4);
            this.groupBoxBuy.Location = new System.Drawing.Point(26, 234);
            this.groupBoxBuy.Name = "groupBoxBuy";
            this.groupBoxBuy.Size = new System.Drawing.Size(516, 225);
            this.groupBoxBuy.TabIndex = 23;
            this.groupBoxBuy.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(69, 19);
            this.labelName.TabIndex = 31;
            this.labelName.Text = "File Name";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(86, 150);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(132, 19);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Kraken195 | 20123523";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(86, 127);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(129, 19);
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "Quazaaar\t | 21537571";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(86, 106);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(129, 19);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Gemini69\t | 30012458";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(13, 179);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.TabIndex = 21;
            this.metroLabel9.Text = "Total = $1.55";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(87, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Kraken221 | 32351123";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(87, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "BigMike | 409123879";
            // 
            // metroCheckBox8
            // 
            this.metroCheckBox8.AutoSize = true;
            this.metroCheckBox8.Location = new System.Drawing.Point(13, 152);
            this.metroCheckBox8.Name = "metroCheckBox8";
            this.metroCheckBox8.Size = new System.Drawing.Size(50, 15);
            this.metroCheckBox8.TabIndex = 25;
            this.metroCheckBox8.Text = "$1.80";
            this.metroCheckBox8.UseSelectable = true;
            // 
            // metroCheckBox7
            // 
            this.metroCheckBox7.AutoSize = true;
            this.metroCheckBox7.Location = new System.Drawing.Point(13, 131);
            this.metroCheckBox7.Name = "metroCheckBox7";
            this.metroCheckBox7.Size = new System.Drawing.Size(50, 15);
            this.metroCheckBox7.TabIndex = 24;
            this.metroCheckBox7.Text = "$1.45";
            this.metroCheckBox7.UseSelectable = true;
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.AutoSize = true;
            this.metroCheckBox6.Location = new System.Drawing.Point(13, 110);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(50, 15);
            this.metroCheckBox6.TabIndex = 23;
            this.metroCheckBox6.Text = "$1.30";
            this.metroCheckBox6.UseSelectable = true;
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.Location = new System.Drawing.Point(13, 89);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(50, 15);
            this.metroCheckBox5.TabIndex = 22;
            this.metroCheckBox5.Text = "$1.70";
            this.metroCheckBox5.UseSelectable = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(13, 68);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(50, 15);
            this.metroCheckBox4.TabIndex = 21;
            this.metroCheckBox4.Text = "$1.50";
            this.metroCheckBox4.UseSelectable = true;
            // 
            // displayTime
            // 
            this.displayTime.AutoSize = true;
            this.displayTime.Location = new System.Drawing.Point(80, 133);
            this.displayTime.Name = "displayTime";
            this.displayTime.Size = new System.Drawing.Size(173, 19);
            this.displayTime.TabIndex = 22;
            this.displayTime.Text = "Active Date/ Time DIsplayed";
            this.displayTime.Click += new System.EventHandler(this.displayTime_Click);
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(344, 506);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(75, 23);
            this.Buy.TabIndex = 10;
            this.Buy.Text = "Buy";
            this.Buy.UseSelectable = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(425, 580);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(506, 580);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // advButton
            // 
            this.advButton.Location = new System.Drawing.Point(10, 580);
            this.advButton.Name = "advButton";
            this.advButton.Size = new System.Drawing.Size(75, 23);
            this.advButton.TabIndex = 17;
            this.advButton.Text = "Advanced";
            this.advButton.UseSelectable = true;
            this.advButton.Click += new System.EventHandler(this.advButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(36, 506);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(102, 15);
            this.metroCheckBox1.TabIndex = 34;
            this.metroCheckBox1.Text = "With amenities";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(144, 503);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 19);
            this.metroLabel10.TabIndex = 35;
            this.metroLabel10.Text = "+ ($1.00)";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(425, 506);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(128, 19);
            this.metroLabel11.TabIndex = 36;
            this.metroLabel11.Text = "Grand Total = $ 2.55";
            // 
            // Add_Transfernet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 626);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.advButton);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox2);
            this.Name = "Add_Transfernet";
            this.Load += new System.EventHandler(this.Add_Transfernet_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxBuy.ResumeLayout(false);
            this.groupBoxBuy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton selectAllButton;
        private MetroFramework.Controls.MetroButton selectNoneButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton advButton;
        private MetroFramework.Controls.MetroButton Buy;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel displayTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxBuy;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox8;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox7;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroLabel labelSize;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        public MetroFramework.Controls.MetroLabel labelName2;
        public MetroFramework.Controls.MetroLabel labelName;
    }
}