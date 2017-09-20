namespace WindowsFormsApplication1
{
    partial class General
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTorrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTransfernetClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.transferButton = new MetroFramework.Controls.MetroButton();
            this.dlButton = new MetroFramework.Controls.MetroButton();
            this.seedButton = new MetroFramework.Controls.MetroButton();
            this.row1Progress = new MetroFramework.Controls.MetroProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.row1Name = new MetroFramework.Controls.MetroLabel();
            this.row1Num = new MetroFramework.Controls.MetroLabel();
            this.row1Size = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar3 = new MetroFramework.Controls.MetroProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1121, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTorrentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addTorrentToolStripMenuItem
            // 
            this.addTorrentToolStripMenuItem.Name = "addTorrentToolStripMenuItem";
            this.addTorrentToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addTorrentToolStripMenuItem.Text = "Add Transfernet Files";
            this.addTorrentToolStripMenuItem.Click += new System.EventHandler(this.addTorrentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTransfernetClientToolStripMenuItem,
            this.releaseNotesToolStripMenuItem,
            this.reportABugToolStripMenuItem,
            this.fAQToolStripMenuItem,
            this.webpageToolStripMenuItem,
            this.forumsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTransfernetClientToolStripMenuItem
            // 
            this.aboutTransfernetClientToolStripMenuItem.Name = "aboutTransfernetClientToolStripMenuItem";
            this.aboutTransfernetClientToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.aboutTransfernetClientToolStripMenuItem.Text = "About Transfernet Client";
            this.aboutTransfernetClientToolStripMenuItem.Click += new System.EventHandler(this.aboutTransfernetClientToolStripMenuItem_Click);
            // 
            // releaseNotesToolStripMenuItem
            // 
            this.releaseNotesToolStripMenuItem.Name = "releaseNotesToolStripMenuItem";
            this.releaseNotesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.releaseNotesToolStripMenuItem.Text = "Release Notes";
            this.releaseNotesToolStripMenuItem.Click += new System.EventHandler(this.releaseNotesToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reportABugToolStripMenuItem.Text = "Report A Bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.reportABugToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // webpageToolStripMenuItem
            // 
            this.webpageToolStripMenuItem.Name = "webpageToolStripMenuItem";
            this.webpageToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.webpageToolStripMenuItem.Text = "Webpage";
            this.webpageToolStripMenuItem.Click += new System.EventHandler(this.webpageToolStripMenuItem_Click);
            // 
            // forumsToolStripMenuItem
            // 
            this.forumsToolStripMenuItem.Name = "forumsToolStripMenuItem";
            this.forumsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.forumsToolStripMenuItem.Text = "Forums";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Name,
            this.Column2,
            this.Column3,
            this.Column4,
            this.DownSpeed,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(278, 87);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(863, 29);
            this.metroGrid2.TabIndex = 3;
            this.metroGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DividerWidth = 1;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // Name
            // 
            this.Name.DividerWidth = 1;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DividerWidth = 1;
            this.Column2.HeaderText = "Playback";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DividerWidth = 1;
            this.Column3.HeaderText = "Size";
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.DividerWidth = 1;
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            // 
            // DownSpeed
            // 
            this.DownSpeed.DividerWidth = 1;
            this.DownSpeed.HeaderText = "Down Speed";
            this.DownSpeed.Name = "DownSpeed";
            this.DownSpeed.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DividerWidth = 1;
            this.Column5.HeaderText = "Up Speed";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DividerWidth = 1;
            this.Column6.HeaderText = "Estimated Time";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DividerWidth = 1;
            this.Column7.HeaderText = "Seeds/Peers";
            this.Column7.Name = "Column7";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.transferButton);
            this.flowLayoutPanel1.Controls.Add(this.dlButton);
            this.flowLayoutPanel1.Controls.Add(this.seedButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 119);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 500);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(150, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(191, 200);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // transferButton
            // 
            this.transferButton.AllowDrop = true;
            this.transferButton.Location = new System.Drawing.Point(3, 3);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(185, 23);
            this.transferButton.TabIndex = 0;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseSelectable = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // dlButton
            // 
            this.dlButton.Location = new System.Drawing.Point(3, 32);
            this.dlButton.Name = "dlButton";
            this.dlButton.Size = new System.Drawing.Size(185, 23);
            this.dlButton.TabIndex = 3;
            this.dlButton.Text = "Downloading";
            this.dlButton.UseSelectable = true;
            this.dlButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // seedButton
            // 
            this.seedButton.Location = new System.Drawing.Point(3, 61);
            this.seedButton.Name = "seedButton";
            this.seedButton.Size = new System.Drawing.Size(185, 23);
            this.seedButton.TabIndex = 4;
            this.seedButton.Text = "Seeding";
            this.seedButton.UseSelectable = true;
            this.seedButton.Click += new System.EventHandler(this.seedButton_Click);
            // 
            // row1Progress
            // 
            this.row1Progress.Location = new System.Drawing.Point(659, 119);
            this.row1Progress.Name = "row1Progress";
            this.row1Progress.Size = new System.Drawing.Size(101, 19);
            this.row1Progress.TabIndex = 6;
            this.row1Progress.Click += new System.EventHandler(this.metroProgressBar4_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // row1Name
            // 
            this.row1Name.AutoSize = true;
            this.row1Name.Location = new System.Drawing.Point(338, 119);
            this.row1Name.Name = "row1Name";
            this.row1Name.Size = new System.Drawing.Size(94, 19);
            this.row1Name.TabIndex = 7;
            this.row1Name.Text = "Wonderful Life";
            this.row1Name.Visible = false;
            // 
            // row1Num
            // 
            this.row1Num.AutoSize = true;
            this.row1Num.Location = new System.Drawing.Point(318, 119);
            this.row1Num.Name = "row1Num";
            this.row1Num.Size = new System.Drawing.Size(14, 19);
            this.row1Num.TabIndex = 8;
            this.row1Num.Text = "1";
            // 
            // row1Size
            // 
            this.row1Size.AutoSize = true;
            this.row1Size.Location = new System.Drawing.Point(618, 119);
            this.row1Size.Name = "row1Size";
            this.row1Size.Size = new System.Drawing.Size(35, 19);
            this.row1Size.TabIndex = 9;
            this.row1Size.Text = "1 GB";
            this.row1Size.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(316, 148);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(16, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "2";
            this.metroLabel4.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(338, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Wonderful_Life";
            this.metroLabel5.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(316, 181);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(16, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "3";
            this.metroLabel6.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(338, 181);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(103, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Its_A_Wonderful";
            this.metroLabel7.Visible = false;
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(659, 148);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(101, 19);
            this.metroProgressBar2.TabIndex = 14;
            this.metroProgressBar2.Click += new System.EventHandler(this.metroProgressBar2_Click);
            // 
            // metroProgressBar3
            // 
            this.metroProgressBar3.Location = new System.Drawing.Point(659, 181);
            this.metroProgressBar3.Name = "metroProgressBar3";
            this.metroProgressBar3.Size = new System.Drawing.Size(101, 19);
            this.metroProgressBar3.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(275, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(863, 297);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(286, 277);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 277);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(14, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroLabel35);
            this.tabPage2.Controls.Add(this.metroLabel34);
            this.tabPage2.Controls.Add(this.metroLabel33);
            this.tabPage2.Controls.Add(this.metroLabel3);
            this.tabPage2.Controls.Add(this.metroLabel32);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.metroLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.Location = new System.Drawing.Point(6, 144);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(90, 19);
            this.metroLabel35.TabIndex = 20;
            this.metroLabel35.Text = "metroLabel35";
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Location = new System.Drawing.Point(6, 105);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(90, 19);
            this.metroLabel34.TabIndex = 19;
            this.metroLabel34.Text = "metroLabel34";
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Location = new System.Drawing.Point(6, 72);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(90, 19);
            this.metroLabel33.TabIndex = 18;
            this.metroLabel33.Text = "metroLabel33";
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(-15, 184);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(863, 23);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "General";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel32
            // 
            this.metroLabel32.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.metroLabel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel32.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel32.Location = new System.Drawing.Point(-15, 37);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(863, 23);
            this.metroLabel32.TabIndex = 17;
            this.metroLabel32.Text = "Transfer";
            this.metroLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel32.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(89, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(736, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Downloaded:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(831, 251);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Peers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(831, 251);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Speed";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(20, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 48);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.logoText;
            this.pictureBox2.Location = new System.Drawing.Point(112, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 50);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1161, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.metroProgressBar3);
            this.Controls.Add(this.metroProgressBar2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.row1Size);
            this.Controls.Add(this.row1Num);
            this.Controls.Add(this.row1Name);
            this.Controls.Add(this.row1Progress);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "General";
            this.Resizable = false;
            this.Text = "          ";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTorrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton transferButton;
        private MetroFramework.Controls.MetroButton dlButton;
        private MetroFramework.Controls.MetroButton seedButton;
        public MetroFramework.Controls.MetroProgressBar row1Progress;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel row1Num;
        private MetroFramework.Controls.MetroLabel row1Size;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        public MetroFramework.Controls.MetroLabel row1Name;
        public MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        public MetroFramework.Controls.MetroProgressBar metroProgressBar3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem aboutTransfernetClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webpageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forumsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel35;
        private MetroFramework.Controls.MetroLabel metroLabel34;
        private MetroFramework.Controls.MetroLabel metroLabel33;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel32;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

