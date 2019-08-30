using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FIC
{
    public partial class FrmMain : Form
    {
        IconCustomizer iconCustomizer = new IconCustomizer();

        public FrmMain()
        {
            InitializeComponent();          
            this.StartPosition = FormStartPosition.CenterScreen;
            ClearFun();
        }        

        private void ClearFun()
        {
            cmbSubfolders.SelectedIndex = 2;
            cmbOption.SelectedIndex = 0;
            cmbFolderType.SelectedIndex = 0;
            cmbIcons.SelectedIndex = 0;

            lblIconLocation.Text = string.Empty;
            picBxIcon.Image = FIC.Properties.Resources.Blank;

            btnSubmit.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set the version
            CurrentVersion();
        }

        private void CurrentVersion()
        {
            string version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
            lblVer.Text = "FIC v" + version;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string outputMsg = "Process has been done.";

            if ((cmbOption.SelectedIndex == 0) && (cmbIcons.SelectedIndex == 0))
            {
                string icoPath = iconCustomizer.GettingIcons(null, picBxIcon);
                lblIconLocation.Text = "Icon Location" + Environment.NewLine + icoPath;

                foreach (string dir in iconCustomizer.AllDir)
                {
                    iconCustomizer.SettingIcons(dir, icoPath, cmbFolderType.SelectedItem.ToString());
                }
            }
            else if ((cmbOption.SelectedIndex == 0) && (cmbIcons.SelectedIndex == 1))
            {
                foreach (string dir in iconCustomizer.AllDir)
                {
                    string icoPath = iconCustomizer.GettingIcons(dir, picBxIcon);
                    lblIconLocation.Text = "Icon Location" + Environment.NewLine + icoPath;

                    iconCustomizer.SettingIcons(dir, icoPath, cmbFolderType.SelectedItem.ToString());
                }
            }
            else if (cmbOption.SelectedIndex == 1)
            {
                foreach (string dir in iconCustomizer.AllDir)
                {
                    iconCustomizer.RettingIcons(dir);
                }
            }
            else
            {
                outputMsg = "Something went wrong.";
            }
            
            MessageBox.Show(outputMsg, "FIC", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFun();
            iconCustomizer.ClearDirectories(rtxtbxOutput);
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            btnSelectFolder.Text = "Please wait...";

            Boolean status = iconCustomizer.SelectDirectory(cmbSubfolders.SelectedIndex, rtxtbxOutput);
            btnSubmit.Enabled = status;

            btnSelectFolder.Text = "Click";
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex == 1)
            {
                cmbIcons.Enabled = false;
                cmbFolderType.Enabled = false;
            }
            else
            {
                cmbIcons.Enabled = true;
                cmbFolderType.Enabled = true;
            }
        }

        private void cmbFolderType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.StartPosition = FormStartPosition.CenterScreen;
            about.TopMost = true;
            about.Show();
        }

        private void troubleshootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTroubleshoot Trblsht = new FrmTroubleshoot();
            Trblsht.StartPosition = FormStartPosition.CenterScreen;
            Trblsht.TopMost = true;
            Trblsht.Show();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Donate();
        }

        private void pbPaypal_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Donate();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:dimuththarindu@mail.com");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFun();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pNGToICOConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://convertico.com/");
            }
            catch (Exception)
            {
            }            
        }

        private void findIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.myiconfinder.com/");
                System.Diagnostics.Process.Start("https://www.iconfinder.com/");
                System.Diagnostics.Process.Start("https://www.flaticon.com/");
            }
            catch (Exception)
            {
            }            
        }

        private void cmbSubfolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            iconCustomizer.ClearDirectories(rtxtbxOutput);
        }

        private void msDefault_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
