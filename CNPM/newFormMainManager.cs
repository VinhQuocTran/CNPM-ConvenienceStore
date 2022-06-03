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
    public partial class newFormMainManager : Form
    {
        public newFormMainManager()
        {
            InitializeComponent();
            setActivePanel(controlManageProduct1);
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnChangePassword.Height;
            SidePanel.Top = btnChangePassword.Top;
            setActivePanel(controlChangePassword1);
            
        }

        public void setActivePanel(UserControl control)
        {
            controlManageProduct1.Visible = false;
            controlManageCashier1.Visible = false;
            controlManageCategory1.Visible = false;
            controlChangePassword1.Visible = false;
            control.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            this.Hide();
            login.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProduct.Height;
            SidePanel.Top = btnProduct.Top;
            setActivePanel(controlManageProduct1);
            controlManageProduct1.addCbbCategory();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCategory.Height;
            SidePanel.Top = btnCategory.Top;
            setActivePanel(controlManageCategory1);
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCashier.Height;
            SidePanel.Top = btnCashier.Top;
            setActivePanel(controlManageCashier1);
        }
    }
}
