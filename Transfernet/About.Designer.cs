namespace WindowsFormsApplication1
{
    partial class About
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
            this.webButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // webButton
            // 
            this.webButton.Location = new System.Drawing.Point(23, 304);
            this.webButton.Name = "webButton";
            this.webButton.Size = new System.Drawing.Size(75, 23);
            this.webButton.TabIndex = 0;
            this.webButton.Text = "Webpage";
            this.webButton.UseSelectable = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(236, 304);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(310, 171);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "All Rights Reserved.\r\n\r\n\r\nThanks for using Transfernet!  We hope you enjoyed\r\nyou" +
    "r experience. \r\n\r\nThanks to:\r\n\r\n";
            this.metroLabel2.WrapToLine = true;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 333);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.webButton);
            this.Name = "About";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton webButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}