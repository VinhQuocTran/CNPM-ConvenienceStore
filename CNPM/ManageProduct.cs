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
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

   
        SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");
        private void addCbbCategory()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            try
            {
                cnn.Open();

                cmd = new SqlCommand("Select madanhmuc From danhmuc", cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())

                {
                    cbbCategories.Items.Add(dr[0]).ToString();
                    cbbCategory1.Items.Add(dr[0]).ToString();
                }
                dr.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      

        private void btnADDProduct_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string query = "insert into sanpham values('" + txtID.Text +
                    "','" + txtName.Text + "','" + txtPrice.Text + "','" + cbbUnit.Text + "','" +
                    cbbCategories.Text + "',"+txtQuantity.Text+")";
                SqlCommand sqlCommand = new SqlCommand(query, cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thêm sản phẩm thành công");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showDataGrid()
        {
            cnn.Open();
            string query = "select * from sanpham";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, cnn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridProduct.DataSource = dataSet.Tables[0];
            cnn.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ControlManage controlManage = new ControlManage();
            controlManage.Show();
            this.Hide();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            addCbbCategory();
            showDataGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showDataGrid();
        }
    }
}
