using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageCashier : Form
    {
        public ManageCashier()
        {
            InitializeComponent();
        }

        /*private void ManageCashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangTienLoiDataSet.taikhoan' table. You can move, or remove it, as needed.
            //SqlConnection cnn;
            //cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");
            //cnn.Open();
            //MessageBox.Show("Connection Open !");
            //cnn.Close();
        }*/

     



        private void btnCashier_Click(object sender, EventArgs e)
        {
            ManageProduct manaProduct = new ManageProduct();
            manaProduct.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ManageCategory manageCategory = new ManageCategory();
            manageCategory.Show();
            this.Hide();
        }
    }
}
