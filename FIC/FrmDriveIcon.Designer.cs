namespace FIC
{
    partial class FrmDriveIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDriveIcon));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxLetter = new System.Windows.Forms.ComboBox();
            this.picBxIcon = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Drive";
            // 
            // cmbBxLetter
            // 
            this.cmbBxLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxLetter.FormattingEnabled = true;
            this.cmbBxLetter.Location = new System.Drawing.Point(133, 42);
            this.cmbBxLetter.Name = "cmbBxLetter";
            this.cmbBxLetter.Size = new System.Drawing.Size(198, 24);
            this.cmbBxLetter.TabIndex = 1;
            // 
            // picBxIcon
            // 
            this.picBxIcon.Image = global::FIC.Properties.Resources.Blank;
            this.picBxIcon.Location = new System.Drawing.Point(397, 93);
            this.picBxIcon.Name = "picBxIcon";
            this.picBxIcon.Size = new System.Drawing.Size(170, 160);
            this.picBxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxIcon.TabIndex = 3;
            this.picBxIcon.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 94);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 48);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.BackColor = System.Drawing.SystemColors.Control;
            this.lblProgramName.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.ForeColor = System.Drawing.Color.DimGray;
            this.lblProgramName.Location = new System.Drawing.Point(14, 19);
            this.lblProgramName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(351, 47);
            this.lblProgramName.TabIndex = 37;
            this.lblProgramName.Text = "Change Drive Icon";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.cmbBxLetter);
            this.groupBox1.Location = new System.Drawing.Point(23, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 190);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // FrmDriveIcon
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 303);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.picBxIcon);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDriveIcon";
            this.Text = "Change Drive Icon";
            this.Load += new System.EventHandler(this.FrmDriveIcon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxLetter;
        private System.Windows.Forms.PictureBox picBxIcon;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}