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
    public partial class ControlManage : Form
    {
        public ControlManage()
        {
            InitializeComponent();
            Load += ControlManage_Load_1;
        }

        public void setActivityPanel(UserControl control)
        {
            controlManageProduct1.Visible = false;
            controlManageCashier1.Visible = false;
            controlManageCategory1.Visible = false;
            control.Visible = true;
        }
        private void ControlManage_Load_1(object sender, EventArgs e)
        {
            setActivityPanel(controlManageProduct1);
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            setActivityPanel(controlManageProduct1);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            setActivityPanel(controlManageCategory1);
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            setActivityPanel(controlManageCashier1);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
