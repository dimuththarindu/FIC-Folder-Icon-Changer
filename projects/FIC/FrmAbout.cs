using System;
using System.Windows.Forms;

namespace FIC
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btnAboutOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {

        }

        private void lblHomeURL_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://dimuththarindu.github.io/FIC-Folder-Icon-Changer/");
            }
            catch (Exception)
            {
            }
        }

        private void lblContactMail_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("mailto:dimuththarindu@mail.com");
            }
            catch (Exception)
            {
            }            
        }

        private void lblLicense_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.gnu.org/licenses/lgpl-3.0.txt");
            }
            catch (Exception)
            {
            }
        }
    }
}
