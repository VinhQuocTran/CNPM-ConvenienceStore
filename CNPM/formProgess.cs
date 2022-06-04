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
            circularProgressBar.Value += 1;
            circularProgressBar.Text = circularProgressBar.Value.ToString() + "%";
            if (circularProgressBar.Value == 100)
            {
                timer.Enabled = false;
                formLogin formLogin = new formLogin();
                this.Hide();
                formLogin.Show();
            }
        }

        private void formProgess_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
