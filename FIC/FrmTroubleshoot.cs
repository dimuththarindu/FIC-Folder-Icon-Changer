using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FIC
{
    public partial class FrmTroubleshoot : Form
    {
        public FrmTroubleshoot()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.FileName = "cmd";
                proc.Arguments = "/C shutdown -f -r -t 5";
                Process.Start(proc);
            }
            catch (Exception)
            {
                this.Dispose();
            }            
        }

        private void btnRestartCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.FileName = "cmd";
                proc.Arguments = "/C shutdown -a";
                Process.Start(proc);
            }
            catch (Exception)
            {
                this.Dispose();
            }
            
        }

        private void btnAboutOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
