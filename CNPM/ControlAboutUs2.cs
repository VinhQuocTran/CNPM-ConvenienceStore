using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ControlAboutUs2 : UserControl
    {
        public ControlAboutUs2()
        {
            InitializeComponent();
        }

        private void iconPictureBoxGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/VinhQuocTran");
        }

        private void iconPictureBoxFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/vinhquoc2103");
        }
    }
}
