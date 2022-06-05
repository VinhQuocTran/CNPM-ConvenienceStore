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
    public partial class ControlAboutUs3 : UserControl
    {
        public ControlAboutUs3()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void iconPictureBoxGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RonaldodeLema");

        }

        private void iconPictureBoxFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/vanthao.tran.101102");

        }
    }
}
