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
    public partial class newFormMainCashier : Form
    {
        public newFormMainCashier()
        {
            InitializeComponent();
        }

        private void buttonCreateBill_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCreateBill.Height;
            setActivePanel(createBillUserControl1);
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonSearchProduct.Height;
            setActivePanel(searchProductUserControl1);
        }

        private void buttonClearBill_Click(object sender, EventArgs e)
        {
            ControlCreateBill control = createBillUserControl1;
            control.orderDGV.Rows.Clear();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonChangePassword.Height;
        }

        public void setActivePanel(UserControl control)
        {
            // Disable all user controls
            createBillUserControl1.Visible = false;
            searchProductUserControl1.Visible = false;

            // Enable 1 user control
            control.Visible = true;
        }


    }
}
