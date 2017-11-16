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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.labelTrans = new MetroFramework.Controls.MetroLabel();
            this.labelTotal = new MetroFramework.Controls.MetroLabel();
            this.labelSeeder = new MetroFramework.Controls.MetroLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.labelPrice = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.labelName2 = new MetroFramework.Controls.MetroLabel();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.advButton = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buyButton = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.labelPath = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelSize = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.metroPanel1);
            this.groupBox2.Controls.Add(this.labelTrans);
            this.groupBox2.Controls.Add(this.labelTotal);
            this.groupBox2.Controls.Add(this.labelSeeder);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.labelPrice);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(10, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 383);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(13, 29);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(155, 19);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Maximum Allowed Price";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(198, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 40;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(13, 148);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(565, 229);
            this.metroPanel1.TabIndex = 39;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // labelTrans
            // 
            this.labelTrans.AutoSize = true;
            this.labelTrans.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTrans.Location = new System.Drawing.Point(287, 126);
            this.labelTrans.Name = "labelTrans";
            this.labelTrans.Size = new System.Drawing.Size(122, 19);
            this.labelTrans.TabIndex = 38;
            this.labelTrans.Text = "Sucessful Transfers";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTotal.Location = new System.Drawing.Point(198, 60);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(17, 19);
            this.labelTotal.TabIndex = 40;
            this.labelTotal.Text = "0";
            // 
            // labelSeeder
            // 
            this.labelSeeder.AutoSize = true;
            this.labelSeeder.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelSeeder.Location = new System.Drawing.Point(134, 126);
            this.labelSeeder.Name = "labelSeeder";
            this.labelSeeder.Size = new System.Drawing.Size(50, 19);
            this.labelSeeder.TabIndex = 37;
            this.labelSeeder.Text = "Seeder";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(495, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 35;
            this.button3.TabStop = false;
            this.button3.Text = "Select None";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPrice.Location = new System.Drawing.Point(23, 126);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 19);
            this.labelPrice.TabIndex = 36;
            this.labelPrice.Text = "Price";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(13, 60);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(91, 19);
            this.metroLabel8.TabIndex = 39;
            this.metroLabel8.Text = "Average Cost";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(405, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 34;
            this.button2.TabStop = false;
            this.button2.Text = "Select All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelName2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelName2.Location = new System.Drawing.Point(10, 23);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(149, 25);
            this.labelName2.TabIndex = 32;
            this.labelName2.Text = "Added File Name";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(520, 590);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // advButton
            // 
            this.advButton.Location = new System.Drawing.Point(10, 590);
            this.advButton.Name = "advButton";
            this.advButton.Size = new System.Drawing.Size(75, 23);
            this.advButton.TabIndex = 17;
            this.advButton.TabStop = false;
            this.advButton.Text = "Advanced";
            this.advButton.UseSelectable = true;
            this.advButton.Click += new System.EventHandler(this.advButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(401, 590);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 37;
            this.buyButton.TabStop = false;
            this.buyButton.Text = "Buy";
            this.buyButton.UseSelectable = true;
            this.buyButton.Click += new System.EventHandler(this.Buy_Click_1);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Dollar $USD"});
            this.metroComboBox1.Location = new System.Drawing.Point(651, 281);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 43;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(651, 256);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 44;
            this.metroLabel2.Text = "Display Currency";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.labelPath);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(10, 90);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(591, 105);
            this.metroPanel2.TabIndex = 45;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(13, 4);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(83, 19);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "metroLabel4";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "Included Files:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(651, 29);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(47, 19);
            this.labelSize.TabIndex = 47;
            this.labelSize.Text = "filesize";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(651, 590);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(125, 23);
            this.metroButton1.TabIndex = 48;
            this.metroButton1.Text = "Free Preview";
            this.metroButton1.UseSelectable = true;
            // 
            // Add_Transfernet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 626);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.advButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox2);
            this.Name = "Add_Transfernet";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Add_Transfernet_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton advButton;
        private System.Windows.Forms.Timer timer1;
        public MetroFramework.Controls.MetroLabel labelName2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroButton buyButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel labelTrans;
        private MetroFramework.Controls.MetroLabel labelSeeder;
        private MetroFramework.Controls.MetroLabel labelPrice;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel labelTotal;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labelSize;
        private MetroFramework.Controls.MetroLabel labelPath;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}