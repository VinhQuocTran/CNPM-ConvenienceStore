﻿using System;
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
    public partial class ThirdUC : UserControl
    {
        public ThirdUC()
        {
            InitializeComponent();
        }

        private void iconPictureBoxGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tmt203");

        }

        private void iconPictureBoxFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/tmt.4869");

        }
    }
}
