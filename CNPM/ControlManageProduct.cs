﻿using System;
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
    public partial class ControlManageProduct : UserControl
    {
        public ControlManageProduct()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");
        public void addCbbCategory()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            cbbCategories.Items.Clear();
            try
            {
                cnn.Open();

                cmd = new SqlCommand("Select tendanhmuc From danhmuc", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    cbbCategories.Items.Add(dr[0]).ToString();
                }
                dr.Close();
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
            string query= "SELECT masp as \" Mã sản phẩm\",tensp as \"Tên Sản Phẩm\",giaban as \"Giá bán\",donvitinh as \"Đơn vị tính\",madanhmuc as \" Mã danh mục\",hangtrongkho as \" Hàng trong kho\" from sanpham";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, cnn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridProduct.DataSource = dataSet.Tables[0];
            cnn.Close();
        }

        public string convertIDtoNameCategory()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            string nameCategory="";
            try
            {
                cnn.Open();
                string query = "select madanhmuc from danhmuc where tendanhmuc =N'" + cbbCategories.Text + "'";
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    nameCategory=dr[0].ToString();
                }
                dr.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
            return nameCategory;
        }
        private void btnADDProduct_Click(object sender, EventArgs e)
        {
            string nameCategory = "";
            nameCategory = convertIDtoNameCategory();
            try
            {
                cnn.Open();
                SqlDataAdapter oks = new SqlDataAdapter("SELECT * FROM sanpham where masp = '" + txtID.Text + "'", cnn);
                DataSet dataSet = new DataSet();
                oks.Fill(dataSet);
                if (txtID.Text==""|| txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || txtUnit.Text == "" 
                    || cbbCategories.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    cnn.Close();

                }
                else if (dataSet.Tables["Table"].Rows.Count > 0)
                {
                    MessageBox.Show("Mã sản phẩm này đã tồn tại");
                    cnn.Close();
                }
                else
                {
                    string query = "insert into sanpham values(N'" + txtID.Text +
                        "',N'" + txtName.Text + "',N'" + txtPrice.Text + "',N'" + txtUnit.Text + "',N'" +
                        nameCategory + "'," + txtQuantity.Text + ")";
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm sản phẩm thành công");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                cnn.Open();
                SqlDataAdapter oks = new SqlDataAdapter("SELECT * FROM chitiethoadon where masp = '" + txtID.Text + "'", cnn);
                DataSet dataSet = new DataSet();
                oks.Fill(dataSet);
                if (dataSet.Tables["Table"].Rows.Count > 0)
                {
                    query = "alter table chitiethoadon nocheck constraint all";
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    query = "delete sanpham where masp = N'" + txtID.Text + "'";
                    sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    query = "alter table chitiethoadon check constraint all";
                    sqlCommand = new SqlCommand(query, cnn);
                    MessageBox.Show("Xóa sản phẩm thành công");
                    cnn.Close();
                    showDataGrid();
                }
                else
                {
                    query = "delete sanpham where masp = N'" + txtID.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa sản phẩm thành công");
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

        private void ControlManageProduct_Load(object sender, EventArgs e)
        {
            addCbbCategory();
            showDataGrid();
        }

        private void txtSampleProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string query = "select masp as \" Mã sản phẩm\",tensp as \"Tên Sản Phẩm\",giaban as \"Giá bán\",donvitinh as \"Đơn vị tính\",madanhmuc as \" Mã danh mục\",hangtrongkho as \" Hàng trong kho\" from sanpham where  tensp  like N'%" + txtSampleProduct.Text + "%'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, cnn);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridProduct.DataSource = dataSet.Tables[0];
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idCategory = "";
            idCategory = convertIDtoNameCategory();

            try
            {
                cnn.Open();
                if (txtID.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || txtUnit.Text == ""
                  || cbbCategories.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    cnn.Close();

                }
                else
                {
                    string query = "update sanpham set masp=N'" + txtID.Text +
                   "', tensp=N'" + txtName.Text + "', giaban = " + txtPrice.Text +
                   ",donvitinh = N'" + txtUnit.Text + "', madanhmuc=N'" + idCategory
                   + "',hangtrongkho =" + txtQuantity.Text + " where masp = N'" + txtID.Text + "' or tensp=N'" + txtName.Text + "N'";
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Sửa thông tin sản phẩm thành công");
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
        public string convertNametoIDCategory()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            string nameCategory = "";
            string idCategory = dataGridProduct.SelectedRows[0].Cells[4].Value.ToString();
            try
            {
                cnn.Open();
                string query = "select tendanhmuc from danhmuc where madanhmuc =N'" + idCategory+ "'";
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nameCategory = dr[0].ToString();
                }
                dr.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
            return nameCategory;
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dataGridProduct.SelectedRows[0].Cells[2].Value.ToString();
            txtUnit.Text = dataGridProduct.SelectedRows[0].Cells[3].Value.ToString();
            cbbCategories.Text = convertNametoIDCategory();
            txtQuantity.Text = dataGridProduct.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void textBoxProPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
                e.Handled = true;

            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
                e.Handled = true;
        }

        private void textBoxProQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
                e.Handled = true;

            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
                e.Handled = true;
        }
    }
}
