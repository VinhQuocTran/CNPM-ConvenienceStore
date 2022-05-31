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
        }



        private void btnCategory_Click(object sender, EventArgs e)
        {
            ManageCategory manageCategory = new ManageCategory();
            manageCategory.Show();
            this.Hide();
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            ManageProduct manaProduct = new ManageProduct();
            manaProduct.Show();
            this.Hide();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            ManageCashier manageCashier = new ManageCashier();
            manageCashier.Show();
            this.Hide();
        }
    }
}
