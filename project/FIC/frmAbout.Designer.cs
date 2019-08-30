namespace FIC
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblContactMail = new System.Windows.Forms.Label();
            this.lblHomeURL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAboutOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIC - Folder Icon Changer";
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.label2);
            this.gbAbout.Controls.Add(this.lblVer);
            this.gbAbout.Controls.Add(this.lblLicense);
            this.gbAbout.Controls.Add(this.lblContactMail);
            this.gbAbout.Controls.Add(this.lblHomeURL);
            this.gbAbout.Controls.Add(this.label4);
            this.gbAbout.Controls.Add(this.label3);
            this.gbAbout.Controls.Add(this.label1);
            this.gbAbout.Location = new System.Drawing.Point(344, 47);
            this.gbAbout.Margin = new System.Windows.Forms.Padding(4);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Padding = new System.Windows.Forms.Padding(4);
            this.gbAbout.Size = new System.Drawing.Size(695, 366);
            this.gbAbout.TabIndex = 5;
            this.gbAbout.TabStop = false;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLicense.Location = new System.Drawing.Point(23, 247);
            this.lblLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(600, 34);
            this.lblLicense.TabIndex = 9;
            this.lblLicense.Text = "This program is a freeware and released under the GNU Lesser General Public Licen" +
    "se v3.0. \r\nA copy of the license can be obtained at https://www.gnu.org/licenses" +
    "/lgpl-3.0.txt";
            this.lblLicense.Click += new System.EventHandler(this.lblLicense_Click);
            // 
            // lblContactMail
            // 
            this.lblContactMail.AutoSize = true;
            this.lblContactMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContactMail.Location = new System.Drawing.Point(23, 148);
            this.lblContactMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactMail.Name = "lblContactMail";
            this.lblContactMail.Size = new System.Drawing.Size(171, 17);
            this.lblContactMail.TabIndex = 8;
            this.lblContactMail.Text = "dimuththarindu@mail.com";
            this.lblContactMail.Click += new System.EventHandler(this.lblContactMail_Click);
            // 
            // lblHomeURL
            // 
            this.lblHomeURL.AutoSize = true;
            this.lblHomeURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHomeURL.Location = new System.Drawing.Point(23, 203);
            this.lblHomeURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomeURL.Name = "lblHomeURL";
            this.lblHomeURL.Size = new System.Drawing.Size(366, 17);
            this.lblHomeURL.TabIndex = 7;
            this.lblHomeURL.Text = "https://dimuththarindu.github.io/FIC-Folder-Icon-Changer/";
            this.lblHomeURL.Click += new System.EventHandler(this.lblHomeURL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Homepage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Developed by DT";
            // 
            // btnAboutOK
            // 
            this.btnAboutOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAboutOK.Location = new System.Drawing.Point(919, 433);
            this.btnAboutOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboutOK.Name = "btnAboutOK";
            this.btnAboutOK.Size = new System.Drawing.Size(120, 40);
            this.btnAboutOK.TabIndex = 4;
            this.btnAboutOK.Text = "OK";
            this.btnAboutOK.UseVisualStyleBackColor = true;
            this.btnAboutOK.Click += new System.EventHandler(this.btnAboutOK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FIC.Properties.Resources.DefaultIcon;
            this.pictureBox1.Location = new System.Drawing.Point(49, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(23, 52);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(144, 17);
            this.lblVer.TabIndex = 10;
            this.lblVer.Text = "Version - FIC v0.0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contact us";
            // 
            // FrmAbout
            // 
            this.AcceptButton = this.btnAboutOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAboutOK;
            this.ClientSize = new System.Drawing.Size(1079, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbAbout);
            this.Controls.Add(this.btnAboutOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAboutOK;
        private System.Windows.Forms.Label lblHomeURL;
        private System.Windows.Forms.Label lblContactMail;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label label2;
    }
}