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
    public partial class ControlAboutUs5 : UserControl
    {
        public ControlAboutUs5()
        {
            InitializeComponent();
        }

        private void iconPictureBoxFB_Click(object sender, EventArgs e)
        {        
            System.Diagnostics.Process.Start("https://www.facebook.com/vietlevan.0503");
        }
    }
}
