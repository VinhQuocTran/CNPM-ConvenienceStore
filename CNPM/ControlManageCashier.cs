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

        private void btnADDCashier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtPassword.Text == "" || txtUsername.Text == "" || txtSalary.Text == ""
                    || cbbAccountType.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    cnn.Open();
                    string query = "insert into taikhoan values('" + txtUsername.Text +
                        "','" + txtPassword.Text + "',N'" + txtName.Text + "'," + txtSalary.Text + ",'"
                        + dtDayWorking.Value.Date + "','" + dtpBirthDay.Value.Date + "','" + cbbAccountType.Text + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công");
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
            string query = "SELECT matk, tentk as \" Tên tài khoản\",matkhau as \"Mật khẩu\",hoten as \"Họ tên\",mucluong as \"Mức lương\",ngaynhanviec as \" Ngày nhận việc\",ngaysinh as \"Ngày sinh\", loaitk as\" Loại tài khoản\" from taikhoan";

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

                if (txtName.Text == "" || txtPassword.Text == "" || txtUsername.Text == "" || txtSalary.Text == ""
                    || cbbAccountType.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    cnn.Close();
                }
                else
                {
                    string matk = dataGridCashier.SelectedRows[0].Cells[0].Value.ToString();
                    string query = "delete taikhoan where matk = " + matk;
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string matk = dataGridCashier.SelectedRows[0].Cells[0].Value.ToString();
                string query = "update taikhoan set tentk='" + txtUsername.Text +
                    "', matkhau='" + txtPassword.Text + "', hoten = N'" + txtName.Text +
                    "',mucluong = " +txtSalary.Text+ ", ngaynhanviec='" + dtDayWorking.Value.Date 
                    + "',ngaysinh ='" + dtpBirthDay.Value.Date +"', loaitk='"+cbbAccountType.Text+ "' where matk = " + matk;
                SqlCommand sqlCommand = new SqlCommand(query, cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin nhân viên thành công");
                cnn.Close();
                showDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void dataGridCashier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUsername.Text = dataGridCashier.SelectedRows[0].Cells[1].Value.ToString();
                txtPassword.Text = dataGridCashier.SelectedRows[0].Cells[2].Value.ToString();
                txtName.Text = dataGridCashier.SelectedRows[0].Cells[3].Value.ToString();
                txtSalary.Text = dataGridCashier.SelectedRows[0].Cells[4].Value.ToString();
                string[] arr = dataGridCashier.SelectedRows[0].Cells[5].Value.ToString().Split('/');
                dtDayWorking.Value = new DateTime(Convert.ToInt32(arr[2].Split(' ')[0]), Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]));
                string[] arr1 = dataGridCashier.SelectedRows[0].Cells[6].Value.ToString().Split('/');
                dtpBirthDay.Value = new DateTime(Convert.ToInt32(arr1[2].Split(' ')[0]), Convert.ToInt32(arr1[0]), Convert.ToInt32(arr1[1]));
                cbbAccountType.Text = dataGridCashier.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
