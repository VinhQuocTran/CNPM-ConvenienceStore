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
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            ManageCashier manageCashier = new ManageCashier();
            manageCashier.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ManageProduct manaProduct = new ManageProduct();
            manaProduct.Show();
            this.Hide();
        }
        SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");
        private void btnADDCashier_Click(object sender, EventArgs e)
        {
            try{
                cnn.Open();
                string query = "insert into danhmuc values('" + txtID.Text +"','"+ txtName.Text +"','"+ txtDescription.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query,cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Add Category successful");
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showDataGrid()
        {
            cnn.Open();
            string query = "select * from danhmuc";
            SqlDataAdapter sqlDataAdapter= new SqlDataAdapter(query, cnn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridCategoy.DataSource = dataSet.Tables[0];
            cnn.Close();
        }
        private void ManageCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangTienLoiDataSet.danhmuc' table. You can move, or remove it, as needed.
            showDataGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showDataGrid();
        }
    }
}
