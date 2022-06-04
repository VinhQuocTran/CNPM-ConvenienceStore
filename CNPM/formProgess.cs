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

        private Timer time = new Timer();

        private void timer_Tick(object sender, EventArgs e)
        {
            circularProgressBar.Increment(1);
            circularProgressBar.Text = circularProgressBar.Value.ToString() + "%";
            
            if (circularProgressBar.Value == circularProgressBar.Maximum)
            {
                time.Stop();
                this.Hide();
                formLogin formLogin = new formLogin();
                formLogin.Show();
            }
        }

        private void formProgess_Load(object sender, EventArgs e)
        {
            time.Interval = 90;
            circularProgressBar.Maximum = 100;
            time.Tick += new EventHandler(timer_Tick);
            time.Start();
        }

    }
}
