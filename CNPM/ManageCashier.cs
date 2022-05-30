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
        SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");

        private void btnADDCashier_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string query = "insert into taikhoan values('" + txtUsername.Text +
                    "','" + txtPassword.Text + "','" + txtName.Text + "'," + txtAge.Text + ",'" +
                    cbbAccountType.Text + "')";
                MessageBox.Show(query);
                SqlCommand sqlCommand = new SqlCommand(query, cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Add Category successful");
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
            string query = "select * from taikhoan";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, cnn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridCashier.DataSource = dataSet.Tables[0];
            cnn.Close();
        }
        private void ManageCashier_Load(object sender, EventArgs e)
        {
            showDataGrid();
        }

        private void dataGridCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txtUsername.Text = dataGridCashier.SelectedRows[0].Cells[1].Value.ToString();
           txtPassword.Text = dataGridCashier.SelectedRows[0].Cells[2].Value.ToString();
           txtName.Text = dataGridCashier.SelectedRows[0].Cells[3].Value.ToString();
           txtAge.Text = dataGridCashier.SelectedRows[0].Cells[4].Value.ToString();
           cbbAccountType.Text = dataGridCashier.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string matk = dataGridCashier.SelectedRows[0].Cells[0].Value.ToString();
                string query = "delete taikhoan where matk = " + matk;
                SqlCommand sqlCommand = new SqlCommand(query, cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Remove User successful");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string matk = dataGridCashier.SelectedRows[0].Cells[0].Value.ToString();
                string query = "update taikhoan set tentk='"+txtUsername.Text+
                    "', matkhau='"+txtPassword.Text+"', hoten = '"+txtName.Text+
                    "',tuoi = "+txtAge.Text+", loaitk='"+cbbAccountType.Text+"' "+ "where matk = " + matk;
                SqlCommand sqlCommand = new SqlCommand(query, cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update User successful");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}