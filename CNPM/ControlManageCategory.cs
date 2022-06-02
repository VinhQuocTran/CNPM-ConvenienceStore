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
    public partial class ControlManageCategory : UserControl
    {
        public ControlManageCategory()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");

        private void btnAddCateGory_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter oks = new SqlDataAdapter("SELECT * FROM danhmuc where madanhmuc = '" + txtID.Text + "'", cnn);
                DataSet dataSet = new DataSet();
                oks.Fill(dataSet);
                if (dataSet.Tables["Table"].Rows.Count > 0)
                {
                    MessageBox.Show("Mã danh mục này đã tồn tại");
                    cnn.Close();
                }
                else if (txtID.Text == "" || txtName.Text == "" || txtDescription.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    cnn.Close();
                }
                else
                {
                    string query = "insert into danhmuc values('" + txtID.Text + "',N'" + txtName.Text + "',N'" + txtDescription.Text + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Add Category successful");
                    cnn.Close();
                    showDataGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }
        private void showDataGrid()
        {
            cnn.Open();
            string query = "select * from danhmuc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, cnn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridCategoy.DataSource = dataSet.Tables[0];
            cnn.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter oks = new SqlDataAdapter("SELECT * FROM sanpham where madanhmuc = '"+txtID.Text+"'", cnn);
                DataSet dataSet = new DataSet();
                oks.Fill(dataSet);
                if (txtID.Text.Equals("") || txtName.Text.Equals("") || txtDescription.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    cnn.Close();
                }
                else if (dataSet.Tables["Table"].Rows.Count > 1)
                {
                    MessageBox.Show("Vui lòng xóng hết sản phẩm có mã danh mục này");
                    cnn.Close();
                }
                else
                {
                    string query = "delete danhmuc where madanhmuc = '" + txtID.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa danh mục thành công");
                    cnn.Close();
                    showDataGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();

            }
        }


        private void dataGridCategoy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridCategoy.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridCategoy.SelectedRows[0].Cells[1].Value.ToString();
            txtDescription.Text = dataGridCategoy.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ControlManageCategory_Load(object sender, EventArgs e)
        {
            showDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter oks = new SqlDataAdapter("SELECT * FROM sanpham where madanhmuc = '" + txtID.Text + "'", cnn);
                DataSet dataSet = new DataSet();
                oks.Fill(dataSet);
                if (dataSet.Tables["Table"].Rows.Count > 1)
                {
                    MessageBox.Show("Vui lòng xóng hết sản phẩm có mã danh mục này và thử lại");
                    cnn.Close();
                }
                else if (txtID.Text == "" || txtName.Text == "" || txtDescription.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    cnn.Close();
                }
                else
                {
                    string query = "update danhmuc set tendanhmuc=N'" + txtName.Text +
                         "', madanhmuc='" + txtID.Text + "', mieuta = N'" + txtDescription.Text +
                         "' where madanhmuc = '" + txtID.Text + "' or tendanhmuc = N'" + txtName.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Sửa danh mục thành công");
                    cnn.Close();
                    showDataGrid();
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void txtCateGory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string query = "select * from danhmuc where  tendanhmuc  like N'%" + txtCateGory.Text + "%'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, cnn);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridCategoy.DataSource = dataSet.Tables[0];
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }
    }
}
