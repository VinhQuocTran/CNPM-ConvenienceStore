using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formProgess : Form
    {
        public formProgess()
        {
            InitializeComponent();
            circularProgressBar.Hide();
        }

        private void runLabel_Click(object sender, EventArgs e)
        {
            runLabel.Hide();
            circularProgressBar.Show();
            for (int i = 1; i <= circularProgressBar.Maximum; i++)
            {
                Thread.Sleep(5);
                circularProgressBar.Value = i;
                circularProgressBar.Update();
                circularProgressBar.Text = circularProgressBar.Value.ToString() + "%";
            }
            this.Hide();
            formLogin formLogin = new formLogin();
            formLogin.Show();
        }

        private void formProgess_Load(object sender, EventArgs e)
        {
            circularProgressBar.Value = 0;
            circularProgressBar.Minimum = 0;
            circularProgressBar.Maximum = 100;
        }

    }
}
