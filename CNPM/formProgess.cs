using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formProgess : Form
    {
        public formProgess()
        {
            InitializeComponent();
            circularProgressBar.Value = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            circularProgressBar.Value++;
            circularProgressBar.Text = circularProgressBar.Value.ToString() + "%";
            if (circularProgressBar.Value == circularProgressBar.Maximum)
            {
                timer.Enabled = false;
                timer.Stop();
                formLogin formLogin = new formLogin();
                this.Hide();
                formLogin.Show();
            }
        }

        private void formProgess_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Interval = 100;
            circularProgressBar.Maximum = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

    }
}
