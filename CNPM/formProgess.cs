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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            circularProgressBar.Hide();
        }

        private void formProgess_Load(object sender, EventArgs e)
        {
            circularProgressBar.Value = 0;
            circularProgressBar.Minimum = 0;
            circularProgressBar.Maximum = 100;
        }

        private void customBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customBtnEnter_Click(object sender, EventArgs e)
        {
            customBtnEnter.Hide();
            customBtnExit.Hide();
            customBtnAbout.Hide();
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
    }
}
