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
    public partial class ControlManageCashier : UserControl
    {
        public ControlManageCashier()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");

        private void dataGridCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dataGridCashier.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword.Text = dataGridCashier.SelectedRows[0].Cells[2].Value.ToString();
            txtName.Text = dataGridCashier.SelectedRows[0].Cells[3].Value.ToString();
            txtSalary.Text = dataGridCashier.SelectedRows[0].Cells[4].Value.ToString();
            string[] arr = dataGridCashier.SelectedRows[0].Cells[5].Value.ToString().Split('/');
            dtDayWorking.Value = new DateTime( Convert.ToInt32(arr[2].Split(' ')[0]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0]));
            cbbAccountType.Text = dataGridCashier.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnADDCashier_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string query = "insert into taikhoan values('" + txtUsername.Text +
                    "','" + txtPassword.Text + "','" + txtName.Text + "'," + txtSalary.Text + ",'" 
                    +dtDayWorking.Value.Date+"','" + dtpBirthDay.Value.Date + "','"  + cbbAccountType.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query, cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công");
                cnn.Close();
                showDataGrid();
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

        private void ControlManageCashier_Load(object sender, EventArgs e)
        {
            showDataGrid();
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
                showDataGrid();

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
                string query = "update taikhoan set tentk='" + txtUsername.Text +
                    "', matkhau='" + txtPassword.Text + "', hoten = '" + txtName.Text +
                    "',tuoi = " + dtpBirthDay.Value.Date+ ", loaitk='" + cbbAccountType.Text + "' " + "where matk = " + matk;
                SqlCommand sqlCommand = new SqlCommand(query, cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update User successful");
                cnn.Close();
                showDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
