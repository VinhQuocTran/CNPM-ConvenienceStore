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

        private void ManageCashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangTienLoiDataSet.taikhoan' table. You can move, or remove it, as needed.
            this.taikhoanTableAdapter.Fill(this.quanLyCuaHangTienLoiDataSet.taikhoan);
            SqlConnection cnn;
            cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");
            cnn.Open();
            MessageBox.Show("Connection Open !");
            cnn.Close();
        }
    }
}
