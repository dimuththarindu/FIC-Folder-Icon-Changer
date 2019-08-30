using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FIC
{
    public partial class FrmDriveIcon : Form
    {
        IconCustomizer iconCustomizer = new IconCustomizer();
        DriveIconChanger driveIconChanger = new DriveIconChanger();

        public FrmDriveIcon()
        {
            InitializeComponent();            
        }

        private void FrmDriveIcon_Load(object sender, EventArgs e)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            cmbBxLetter.Items.AddRange(alpha.Select(s => s.ToString()).ToArray());

            cmbBxLetter.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //string icoPath = iconCustomizer.GettingIcons(null, picBxIcon);
            string letter = cmbBxLetter.SelectedItem.ToString();
            //driveIconChanger.RegEditor(letter);            
        }
    }
}
