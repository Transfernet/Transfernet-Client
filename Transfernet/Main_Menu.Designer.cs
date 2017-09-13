namespace WindowsFormsApplication1
{
    partial class Transfernet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTorrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.torrentButton = new MetroFramework.Controls.MetroButton();
            this.dlButton = new MetroFramework.Controls.MetroButton();
            this.seedButton = new MetroFramework.Controls.MetroButton();
            this.tabSpeed = new System.Windows.Forms.TabPage();
            this.tabPeers = new System.Windows.Forms.TabPage();
            this.metroGrid3 = new MetroFramework.Controls.MetroGrid();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.filesName = new MetroFramework.Controls.MetroLabel();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroProgressBar4 = new MetroFramework.Controls.MetroProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar3 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPeers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.tabControl.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
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
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
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
            this.metroGrid2.Location = new System.Drawing.Point(273, 100);
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
            this.metroGrid2.Size = new System.Drawing.Size(932, 150);
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
            this.flowLayoutPanel1.Controls.Add(this.torrentButton);
            this.flowLayoutPanel1.Controls.Add(this.dlButton);
            this.flowLayoutPanel1.Controls.Add(this.seedButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 100);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 500);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(150, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(191, 200);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // torrentButton
            // 
            this.torrentButton.Location = new System.Drawing.Point(3, 3);
            this.torrentButton.Name = "torrentButton";
            this.torrentButton.Size = new System.Drawing.Size(185, 23);
            this.torrentButton.TabIndex = 0;
            this.torrentButton.Text = "Torrent";
            this.torrentButton.UseSelectable = true;
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
            // 
            // tabSpeed
            // 
            this.tabSpeed.Location = new System.Drawing.Point(4, 38);
            this.tabSpeed.Name = "tabSpeed";
            this.tabSpeed.Size = new System.Drawing.Size(932, 225);
            this.tabSpeed.TabIndex = 4;
            this.tabSpeed.Text = "Speed";
            // 
            // tabPeers
            // 
            this.tabPeers.Controls.Add(this.metroLabel13);
            this.tabPeers.Controls.Add(this.metroLabel14);
            this.tabPeers.Controls.Add(this.metroLabel15);
            this.tabPeers.Controls.Add(this.metroLabel16);
            this.tabPeers.Controls.Add(this.metroLabel12);
            this.tabPeers.Controls.Add(this.metroLabel11);
            this.tabPeers.Controls.Add(this.metroLabel10);
            this.tabPeers.Controls.Add(this.metroLabel9);
            this.tabPeers.Controls.Add(this.metroGrid3);
            this.tabPeers.Location = new System.Drawing.Point(4, 38);
            this.tabPeers.Name = "tabPeers";
            this.tabPeers.Size = new System.Drawing.Size(932, 225);
            this.tabPeers.TabIndex = 2;
            this.tabPeers.Text = "Peers";
            // 
            // metroGrid3
            // 
            this.metroGrid3.AllowUserToResizeRows = false;
            this.metroGrid3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid3.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid3.EnableHeadersVisualStyles = false;
            this.metroGrid3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.Location = new System.Drawing.Point(0, 0);
            this.metroGrid3.Name = "metroGrid3";
            this.metroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid3.Size = new System.Drawing.Size(929, 154);
            this.metroGrid3.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "IP";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Client";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Flags";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "%";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Down Speed";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Up Speed";
            this.Column13.Name = "Column13";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.metroLabel8);
            this.tabInfo.Controls.Add(this.metroProgressBar1);
            this.tabInfo.Location = new System.Drawing.Point(4, 38);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(932, 225);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "Info";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(92, 0);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(840, 23);
            this.metroProgressBar1.TabIndex = 0;
            // 
            // tabFiles
            // 
            this.tabFiles.Controls.Add(this.filesName);
            this.tabFiles.Location = new System.Drawing.Point(4, 38);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Size = new System.Drawing.Size(932, 225);
            this.tabFiles.TabIndex = 0;
            this.tabFiles.Text = "Files";
            this.tabFiles.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // filesName
            // 
            this.filesName.AutoSize = true;
            this.filesName.Location = new System.Drawing.Point(0, 0);
            this.filesName.Name = "filesName";
            this.filesName.Size = new System.Drawing.Size(0, 0);
            this.filesName.TabIndex = 0;
            this.filesName.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFiles);
            this.tabControl.Controls.Add(this.tabInfo);
            this.tabControl.Controls.Add(this.tabPeers);
            this.tabControl.Controls.Add(this.tabSpeed);
            this.tabControl.Location = new System.Drawing.Point(273, 276);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 3;
            this.tabControl.Size = new System.Drawing.Size(940, 267);
            this.tabControl.TabIndex = 4;
            this.tabControl.UseSelectable = true;
            // 
            // metroProgressBar4
            // 
            this.metroProgressBar4.Location = new System.Drawing.Point(659, 132);
            this.metroProgressBar4.Name = "metroProgressBar4";
            this.metroProgressBar4.Size = new System.Drawing.Size(101, 19);
            this.metroProgressBar4.TabIndex = 6;
            this.metroProgressBar4.Click += new System.EventHandler(this.metroProgressBar4_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(338, 132);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "label1 ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(318, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(14, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(618, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "1 GB";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(316, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(16, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "2";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(338, 161);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "label2";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(316, 194);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(16, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "3";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(338, 194);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(44, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "label3";
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(659, 161);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(101, 19);
            this.metroProgressBar2.TabIndex = 14;
            this.metroProgressBar2.Click += new System.EventHandler(this.metroProgressBar2_Click);
            // 
            // metroProgressBar3
            // 
            this.metroProgressBar3.Location = new System.Drawing.Point(659, 194);
            this.metroProgressBar3.Name = "metroProgressBar3";
            this.metroProgressBar3.Size = new System.Drawing.Size(101, 19);
            this.metroProgressBar3.TabIndex = 15;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(86, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Downloaded:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(0, 17);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(68, 19);
            this.metroLabel9.TabIndex = 1;
            this.metroLabel9.Text = "192.78.10.1";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(120, 17);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(90, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "transfernet 1.0";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(250, 17);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(39, 19);
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "D HP";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(330, 17);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(38, 19);
            this.metroLabel12.TabIndex = 4;
            this.metroLabel12.Text = "100.0";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(330, 35);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(38, 19);
            this.metroLabel13.TabIndex = 8;
            this.metroLabel13.Text = "100.0";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(250, 35);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(39, 19);
            this.metroLabel14.TabIndex = 7;
            this.metroLabel14.Text = "D HP";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(120, 35);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(90, 19);
            this.metroLabel15.TabIndex = 6;
            this.metroLabel15.Text = "transfernet 1.5";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(0, 35);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(89, 19);
            this.metroLabel16.TabIndex = 5;
            this.metroLabel16.Text = "192.278.10.120";
            // 
            // Transfernet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 586);
            this.Controls.Add(this.metroProgressBar3);
            this.Controls.Add(this.metroProgressBar2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressBar4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Transfernet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPeers.ResumeLayout(false);
            this.tabPeers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabFiles.ResumeLayout(false);
            this.tabFiles.PerformLayout();
            this.tabControl.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroButton torrentButton;
        private MetroFramework.Controls.MetroButton dlButton;
        private MetroFramework.Controls.MetroButton seedButton;
        private System.Windows.Forms.TabPage tabSpeed;
        private System.Windows.Forms.TabPage tabPeers;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabFiles;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroLabel filesName;
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        public MetroFramework.Controls.MetroProgressBar metroProgressBar4;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        public MetroFramework.Controls.MetroProgressBar metroProgressBar3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}

