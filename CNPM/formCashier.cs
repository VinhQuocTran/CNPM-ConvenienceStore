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
    public partial class FormCashier : Form
    {
        public FormCashier()
        {
            InitializeComponent();
            setActivePanel(controlCreateBill1);
        }

        private void buttonCreateBill_Click(object sender, EventArgs e)
        {
            SidePanel.Top = buttonCreateBill.Top;
            setActivePanel(controlCreateBill1);
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Top = buttonSearchProduct.Top;
            setActivePanel(controlSearchProduct1);
            controlSearchProduct1.populateProduct();
        }

        private void buttonClearBill_Click(object sender, EventArgs e)
        {
            controlCreateBill1.orderDGV.Rows.Clear();
            ControlCreateBill.totalCart = 0;
            controlCreateBill1.labelCartTotal.Text = ControlCreateBill.totalCart.ToString();
            ControlCreateBill.n = 1;
            MessageBox.Show("Xoá hết sản phẩm trong giỏ hàng thành công");
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonChangePassword.Height;
            SidePanel.Top = buttonChangePassword.Top;
            setActivePanel(controlChangePassword1);
        }

        public void setActivePanel(UserControl control)
        {
            // Disable all user controls
            controlSearchProduct1.Visible = false;
            controlCreateBill1.Visible = false;
            controlChangePassword1.Visible = false;

            // Enable 1 user control
            control.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }
    }
}
