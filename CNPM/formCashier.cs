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
    public partial class formCashier : Form
    {
        public formCashier()
        {
            InitializeComponent();
        }

        public void setActivePanel(UserControl control)
        {
            // Disable all user controls
            createBillUserControl1.Visible = false;
            searchProductUserControl1.Visible = false;

            // Enable 1 user control
            control.Visible = true;
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            setActivePanel(searchProductUserControl1);
            searchProductUserControl1.populateProduct();
        }

        private void formCashier_Load(object sender, EventArgs e)
        {
            setActivePanel(createBillUserControl1);
        }

        private void buttonCreateBill_Click(object sender, EventArgs e)
        {
            setActivePanel(createBillUserControl1);
        }

        private void buttonClearBill_Click(object sender, EventArgs e)
        {
            ControlCreateBill control = createBillUserControl1;
            control.orderDGV.Rows.Clear();
        }
    }
}
