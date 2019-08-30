namespace FIC
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnClear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtxtbxOutput = new System.Windows.Forms.RichTextBox();
            this.cmbIcons = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFolderType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.cmbSubfolders = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblIconLocation = new System.Windows.Forms.Label();
            this.picBxIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbPaypal = new System.Windows.Forms.PictureBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msDefault = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pNGToICOConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.troubleshootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVer = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaypal)).BeginInit();
            this.panel1.SuspendLayout();
            this.msDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(183, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 48);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.rtxtbxOutput);
            this.panel4.Location = new System.Drawing.Point(580, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(949, 617);
            this.panel4.TabIndex = 1;
            // 
            // rtxtbxOutput
            // 
            this.rtxtbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtbxOutput.BackColor = System.Drawing.Color.Gray;
            this.rtxtbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtbxOutput.Location = new System.Drawing.Point(24, 15);
            this.rtxtbxOutput.Margin = new System.Windows.Forms.Padding(10);
            this.rtxtbxOutput.Name = "rtxtbxOutput";
            this.rtxtbxOutput.ReadOnly = true;
            this.rtxtbxOutput.Size = new System.Drawing.Size(872, 574);
            this.rtxtbxOutput.TabIndex = 0;
            this.rtxtbxOutput.Text = "";
            // 
            // cmbIcons
            // 
            this.cmbIcons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIcons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIcons.FormattingEnabled = true;
            this.cmbIcons.Items.AddRange(new object[] {
            "One Icon for all folders",
            "Multiple Icons"});
            this.cmbIcons.Location = new System.Drawing.Point(211, 260);
            this.cmbIcons.Name = "cmbIcons";
            this.cmbIcons.Size = new System.Drawing.Size(280, 24);
            this.cmbIcons.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Select Icon";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbIcons);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbFolderType);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.cmbOption);
            this.groupBox1.Controls.Add(this.cmbSubfolders);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 397);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(211, 204);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(280, 30);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "Click";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 34);
            this.label4.TabIndex = 22;
            this.label4.Text = "Folder Type\r\n(Optimize this folder for... )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Option";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select Folder(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Subfolders";
            // 
            // cmbFolderType
            // 
            this.cmbFolderType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFolderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFolderType.FormattingEnabled = true;
            this.cmbFolderType.Items.AddRange(new object[] {
            "General items",
            "Documents",
            "Pictures",
            "Music",
            "Videos"});
            this.cmbFolderType.Location = new System.Drawing.Point(211, 152);
            this.cmbFolderType.Name = "cmbFolderType";
            this.cmbFolderType.Size = new System.Drawing.Size(280, 24);
            this.cmbFolderType.TabIndex = 3;
            this.cmbFolderType.SelectedIndexChanged += new System.EventHandler(this.cmbFolderType_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(340, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 48);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbOption
            // 
            this.cmbOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "Set Icons",
            "Reset"});
            this.cmbOption.Location = new System.Drawing.Point(211, 87);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(280, 24);
            this.cmbOption.TabIndex = 2;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.cmbOption_SelectedIndexChanged);
            // 
            // cmbSubfolders
            // 
            this.cmbSubfolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSubfolders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubfolders.FormattingEnabled = true;
            this.cmbSubfolders.Items.AddRange(new object[] {
            "Include Subfolders (Top Directory Only)",
            "Include All Subfolders",
            "Without Subfolders"});
            this.cmbSubfolders.Location = new System.Drawing.Point(211, 35);
            this.cmbSubfolders.Name = "cmbSubfolders";
            this.cmbSubfolders.Size = new System.Drawing.Size(280, 24);
            this.cmbSubfolders.TabIndex = 1;
            this.cmbSubfolders.SelectedIndexChanged += new System.EventHandler(this.cmbSubfolders_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblIconLocation);
            this.panel3.Controls.Add(this.picBxIcon);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 617);
            this.panel3.TabIndex = 0;
            // 
            // lblIconLocation
            // 
            this.lblIconLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIconLocation.AutoSize = true;
            this.lblIconLocation.Location = new System.Drawing.Point(212, 456);
            this.lblIconLocation.Name = "lblIconLocation";
            this.lblIconLocation.Size = new System.Drawing.Size(92, 17);
            this.lblIconLocation.TabIndex = 27;
            this.lblIconLocation.Text = "Icon Location";
            // 
            // picBxIcon
            // 
            this.picBxIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picBxIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBxIcon.Image")));
            this.picBxIcon.Location = new System.Drawing.Point(18, 431);
            this.picBxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picBxIcon.Name = "picBxIcon";
            this.picBxIcon.Size = new System.Drawing.Size(170, 160);
            this.picBxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxIcon.TabIndex = 11;
            this.picBxIcon.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.68977F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.31023F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 623F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1532, 623);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(12, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Developed by DT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblVer);
            this.panel2.Controls.Add(this.pbPaypal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 703);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1532, 30);
            this.panel2.TabIndex = 42;
            // 
            // pbPaypal
            // 
            this.pbPaypal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPaypal.BackColor = System.Drawing.Color.Transparent;
            this.pbPaypal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPaypal.Image = global::FIC.Properties.Resources.paypal;
            this.pbPaypal.Location = new System.Drawing.Point(1455, 9);
            this.pbPaypal.Margin = new System.Windows.Forms.Padding(4);
            this.pbPaypal.Name = "pbPaypal";
            this.pbPaypal.Size = new System.Drawing.Size(56, 17);
            this.pbPaypal.TabIndex = 38;
            this.pbPaypal.TabStop = false;
            this.pbPaypal.Click += new System.EventHandler(this.pbPaypal_Click);
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.BackColor = System.Drawing.Color.Transparent;
            this.lblProgramName.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.ForeColor = System.Drawing.Color.DimGray;
            this.lblProgramName.Location = new System.Drawing.Point(13, 33);
            this.lblProgramName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(478, 47);
            this.lblProgramName.TabIndex = 36;
            this.lblProgramName.Text = "FIC - Folder Icon Changer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.msDefault);
            this.panel1.Controls.Add(this.lblProgramName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1532, 80);
            this.panel1.TabIndex = 40;
            // 
            // msDefault
            // 
            this.msDefault.BackColor = System.Drawing.Color.Transparent;
            this.msDefault.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msDefault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msDefault.Location = new System.Drawing.Point(0, 0);
            this.msDefault.Name = "msDefault";
            this.msDefault.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msDefault.Size = new System.Drawing.Size(1532, 28);
            this.msDefault.TabIndex = 37;
            this.msDefault.Text = "menuStrip1";
            this.msDefault.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msDefault_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.pNGToICOConversionToolStripMenuItem,
            this.findIconsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // pNGToICOConversionToolStripMenuItem
            // 
            this.pNGToICOConversionToolStripMenuItem.Name = "pNGToICOConversionToolStripMenuItem";
            this.pNGToICOConversionToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.pNGToICOConversionToolStripMenuItem.Text = "PNG to ICO Conversion";
            this.pNGToICOConversionToolStripMenuItem.Click += new System.EventHandler(this.pNGToICOConversionToolStripMenuItem_Click);
            // 
            // findIconsToolStripMenuItem
            // 
            this.findIconsToolStripMenuItem.Name = "findIconsToolStripMenuItem";
            this.findIconsToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.findIconsToolStripMenuItem.Text = "Find Icons";
            this.findIconsToolStripMenuItem.Click += new System.EventHandler(this.findIconsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donateToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.toolStripSeparator3,
            this.troubleshootToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // troubleshootToolStripMenuItem
            // 
            this.troubleshootToolStripMenuItem.Name = "troubleshootToolStripMenuItem";
            this.troubleshootToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.troubleshootToolStripMenuItem.Text = "Troubleshoot";
            this.troubleshootToolStripMenuItem.Click += new System.EventHandler(this.troubleshootToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.aboutToolStripMenuItem.Text = "About..";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblVer
            // 
            this.lblVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVer.AutoSize = true;
            this.lblVer.ForeColor = System.Drawing.Color.DarkGray;
            this.lblVer.Location = new System.Drawing.Point(136, 4);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(83, 17);
            this.lblVer.TabIndex = 43;
            this.lblVer.Text = "FIC v0.0.0.0";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1532, 733);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIC - Folder Icon Changer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaypal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.msDefault.ResumeLayout(false);
            this.msDefault.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtxtbxOutput;
        private System.Windows.Forms.ComboBox cmbIcons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFolderType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.ComboBox cmbSubfolders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBxIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIconLocation;
        private System.Windows.Forms.MenuStrip msDefault;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem troubleshootToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbPaypal;
        private System.Windows.Forms.ToolStripMenuItem pNGToICOConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblVer;
    }
}

