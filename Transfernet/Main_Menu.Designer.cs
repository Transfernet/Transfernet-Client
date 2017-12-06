

namespace TransferNetClient
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
            this.transferButton = new MetroFramework.Controls.MetroButton();
            this.dlButton = new MetroFramework.Controls.MetroButton();
            this.seedButton = new MetroFramework.Controls.MetroButton();
            this.blockButton = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer0 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(27, 74);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1494, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTorrentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addTorrentToolStripMenuItem
            // 
            this.addTorrentToolStripMenuItem.Name = "addTorrentToolStripMenuItem";
            this.addTorrentToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.addTorrentToolStripMenuItem.Text = "Add Transfernet Files";
            this.addTorrentToolStripMenuItem.Click += new System.EventHandler(this.addTorrentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTransfernetClientToolStripMenuItem
            // 
            this.aboutTransfernetClientToolStripMenuItem.Name = "aboutTransfernetClientToolStripMenuItem";
            this.aboutTransfernetClientToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.aboutTransfernetClientToolStripMenuItem.Text = "About Transfernet Client";
            this.aboutTransfernetClientToolStripMenuItem.Click += new System.EventHandler(this.aboutTransfernetClientToolStripMenuItem_Click);
            // 
            // releaseNotesToolStripMenuItem
            // 
            this.releaseNotesToolStripMenuItem.Name = "releaseNotesToolStripMenuItem";
            this.releaseNotesToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.releaseNotesToolStripMenuItem.Text = "Release Notes";
            this.releaseNotesToolStripMenuItem.Click += new System.EventHandler(this.releaseNotesToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.reportABugToolStripMenuItem.Text = "Report A Bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.reportABugToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // webpageToolStripMenuItem
            // 
            this.webpageToolStripMenuItem.Name = "webpageToolStripMenuItem";
            this.webpageToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.webpageToolStripMenuItem.Text = "Webpage";
            this.webpageToolStripMenuItem.Click += new System.EventHandler(this.webpageToolStripMenuItem_Click);
            // 
            // forumsToolStripMenuItem
            // 
            this.forumsToolStripMenuItem.Name = "forumsToolStripMenuItem";
            this.forumsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.forumsToolStripMenuItem.Text = "Forums";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // transferButton
            // 
            this.transferButton.AllowDrop = true;
            this.transferButton.BackColor = System.Drawing.Color.Transparent;
            this.transferButton.Location = new System.Drawing.Point(27, 151);
            this.transferButton.Margin = new System.Windows.Forms.Padding(4);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(247, 28);
            this.transferButton.TabIndex = 0;
            this.transferButton.TabStop = false;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseSelectable = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // dlButton
            // 
            this.dlButton.Location = new System.Drawing.Point(27, 187);
            this.dlButton.Margin = new System.Windows.Forms.Padding(4);
            this.dlButton.Name = "dlButton";
            this.dlButton.Size = new System.Drawing.Size(247, 28);
            this.dlButton.TabIndex = 3;
            this.dlButton.TabStop = false;
            this.dlButton.Text = "Downloading";
            this.dlButton.UseSelectable = true;
            // 
            // seedButton
            // 
            this.seedButton.Location = new System.Drawing.Point(27, 223);
            this.seedButton.Margin = new System.Windows.Forms.Padding(4);
            this.seedButton.Name = "seedButton";
            this.seedButton.Size = new System.Drawing.Size(247, 28);
            this.seedButton.TabIndex = 4;
            this.seedButton.TabStop = false;
            this.seedButton.Text = "Seeding";
            this.seedButton.UseSelectable = true;
            this.seedButton.Click += new System.EventHandler(this.seedButton_Click);
            // 
            // blockButton
            // 
            this.blockButton.Location = new System.Drawing.Point(27, 259);
            this.blockButton.Margin = new System.Windows.Forms.Padding(4);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(247, 28);
            this.blockButton.TabIndex = 5;
            this.blockButton.TabStop = false;
            this.blockButton.Text = "Blacklist";
            this.blockButton.UseSelectable = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(372, 402);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(1151, 366);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(387, 416);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 341);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroLabel5);
            this.tabPage1.Controls.Add(this.metroLabel4);
            this.tabPage1.Controls.Add(this.metroLabel1);
            this.tabPage1.Controls.Add(this.metroPanel2);
            this.tabPage1.Controls.Add(this.metroLabel17);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1111, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(756, 4);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(21, 20);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "%";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(637, 4);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 20);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Done";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(536, 4);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 20);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Size";
            // 
            // metroPanel2
            // 
            this.metroPanel2.AutoScroll = true;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.HorizontalScrollbar = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(0, 28);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1107, 280);
            this.metroPanel2.TabIndex = 25;
            this.metroPanel2.VerticalScrollbar = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(0, 1);
            this.metroLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(37, 20);
            this.metroLabel17.TabIndex = 1;
            this.metroLabel17.Text = "Path";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroLabel12);
            this.tabPage2.Controls.Add(this.metroLabel11);
            this.tabPage2.Controls.Add(this.metroLabel10);
            this.tabPage2.Controls.Add(this.metroLabel9);
            this.tabPage2.Controls.Add(this.metroLabel8);
            this.tabPage2.Controls.Add(this.metroLabel35);
            this.tabPage2.Controls.Add(this.metroLabel34);
            this.tabPage2.Controls.Add(this.metroLabel33);
            this.tabPage2.Controls.Add(this.metroLabel3);
            this.tabPage2.Controls.Add(this.metroLabel32);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.metroLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1111, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(148, 266);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(99, 20);
            this.metroLabel12.TabIndex = 24;
            this.metroLabel12.Text = "C://Downloads";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(4, 266);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(60, 20);
            this.metroLabel11.TabIndex = 22;
            this.metroLabel11.Text = "Save As:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(148, 166);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(34, 20);
            this.metroLabel10.TabIndex = 23;
            this.metroLabel10.Text = "N/A";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(148, 129);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(17, 20);
            this.metroLabel9.TabIndex = 22;
            this.metroLabel9.Text = "0";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(148, 89);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(17, 20);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "0";
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.Location = new System.Drawing.Point(8, 166);
            this.metroLabel35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(48, 20);
            this.metroLabel35.TabIndex = 20;
            this.metroLabel35.Text = "Status:";
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Location = new System.Drawing.Point(8, 129);
            this.metroLabel34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(90, 20);
            this.metroLabel34.TabIndex = 19;
            this.metroLabel34.Text = "Downloaded:";
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Location = new System.Drawing.Point(8, 89);
            this.metroLabel33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(95, 20);
            this.metroLabel33.TabIndex = 18;
            this.metroLabel33.Text = "Time Elapsed:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(-20, 226);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(1150, 28);
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
            this.metroLabel32.Location = new System.Drawing.Point(-20, 46);
            this.metroLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(1150, 28);
            this.metroLabel32.TabIndex = 17;
            this.metroLabel32.Text = "Transfer";
            this.metroLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel32.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(119, 7);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(981, 28);
            this.progressBar1.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 7);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Downloaded:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.metroPanel3);
            this.tabPage3.Controls.Add(this.metroLabel18);
            this.tabPage3.Controls.Add(this.metroLabel7);
            this.tabPage3.Controls.Add(this.metroLabel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1111, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Peers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.AutoScroll = true;
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.HorizontalScrollbar = true;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 12;
            this.metroPanel3.Location = new System.Drawing.Point(0, 27);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1107, 281);
            this.metroPanel3.TabIndex = 31;
            this.metroPanel3.VerticalScrollbar = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 13;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(517, 0);
            this.metroLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(43, 20);
            this.metroLabel18.TabIndex = 30;
            this.metroLabel18.Text = "Flags";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(296, 0);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(47, 20);
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "Client";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(0, 0);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(21, 20);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "IP";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1111, 312);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Speed";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TransferNetClient.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(27, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 59);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TransferNetClient.Properties.Resources.logoText;
            this.pictureBox2.Location = new System.Drawing.Point(149, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 62);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(372, 119);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(18, 20);
            this.metroLabel13.TabIndex = 16;
            this.metroLabel13.Text = "#";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(467, 119);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(49, 20);
            this.metroLabel14.TabIndex = 16;
            this.metroLabel14.Text = "Name";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(840, 123);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(36, 20);
            this.metroLabel15.TabIndex = 24;
            this.metroLabel15.Text = "Size";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(965, 119);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(99, 20);
            this.metroLabel16.TabIndex = 16;
            this.metroLabel16.Text = "Downloading";
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(372, 146);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1145, 246);
            this.metroPanel1.TabIndex = 26;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1548, 772);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dlButton);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.seedButton);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "General";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroButton transferButton;
        private MetroFramework.Controls.MetroButton dlButton;
        private MetroFramework.Controls.MetroButton seedButton;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer0;
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
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton blockButton;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel3;
    }
}

