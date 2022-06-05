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
                cnn.Open();
                string query = "";
                SqlDataAdapter oks = new SqlDataAdapter("SELECT * FROM taikhoan where tentk = '" + txtUsername.Text+"'", cnn);
                DataSet dataSet = new DataSet();
                oks.Fill(dataSet);
                if (txtName.Text == "" || txtPassword.Text == "" || txtUsername.Text == "" || txtSalary.Text == ""
                    || cbbAccountType.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    cnn.Close();
                }
                else if (dataSet.Tables["Table"].Rows.Count > 0)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại");
                    cnn.Close();
                }
                else
                {
                    query = "insert into taikhoan values('" + txtUsername.Text +
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
            string query = "SELECT tentk as \" Tên tài khoản\",matkhau as \"Mật khẩu\",hoten as \"Họ tên\",mucluong as \"Mức lương\",ngaynhanviec as \" Ngày nhận việc\",ngaysinh as \"Ngày sinh\", loaitk as\" Loại tài khoản\" from taikhoan";
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

        public string getUserID()
        {
            string userID = "";
            SqlCommand cmd;
            SqlDataReader dr;
            try
            {
                cnn.Open();
                string query = "select matk from taikhoan where tentk ='" + txtUsername.Text + "'";
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                   userID= dr[0].ToString();
                }
                dr.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
            return userID;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = getUserID();
                cnn.Open();
                string query = "";
                SqlDataAdapter oks = new SqlDataAdapter("SELECT * FROM hoadon where nguoiban = "+ userID, cnn);
                DataSet dataSet = new DataSet();
                oks.Fill(dataSet);
                if (txtName.Text == "" || txtPassword.Text == "" || txtUsername.Text == "" || txtSalary.Text == ""
                    || cbbAccountType.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    cnn.Close();
                }
                else if (dataSet.Tables["Table"].Rows.Count > 0)
                {
                    query = "alter table hoadon nocheck constraint all";
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    query = "delete taikhoan where matk = " + userID;
                    sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    query = "alter table hoadon check constraint all";
                    sqlCommand = new SqlCommand(query, cnn);
                    MessageBox.Show("Xóa tài khoản thành công");
                    cnn.Close();
                    showDataGrid();
                }
                else if (formLogin.tentk.Equals(txtUsername.Text))
                {
                    MessageBox.Show("Tài khoản này đang được đăng nhập không thể xóa");
                    cnn.Close();
                }
                else
                {
                    query = "delete taikhoan where matk = " + userID;
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
            SqlDataAdapter oks = new SqlDataAdapter("SELECT * FROM taikhoan where tentk = '" + txtUsername.Text + "'", cnn);
            try
            {
                string userID = getUserID();
                cnn.Open();
                string query = "";
                if (txtName.Text == "" || txtPassword.Text == "" || txtUsername.Text == "" || txtSalary.Text == ""
                    || cbbAccountType.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    cnn.Close();
                }
                else
                {
                    query = "update taikhoan set tentk=N'" + txtUsername.Text +
                   "', matkhau ='" + txtPassword.Text + "', hoten = N'" + txtName.Text +
                   "',mucluong = " + txtSalary.Text + ", ngaynhanviec='" + dtDayWorking.Value.Date
                   + "',ngaysinh ='" + dtpBirthDay.Value.Date + "', loaitk='" + cbbAccountType.Text + "' where matk = " + userID;
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Sửa thông tin nhân viên thành công");
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

        private void dataGridCashier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUsername.Text = dataGridCashier.SelectedRows[0].Cells[0].Value.ToString();
                txtPassword.Text = dataGridCashier.SelectedRows[0].Cells[1].Value.ToString();
                txtName.Text = dataGridCashier.SelectedRows[0].Cells[2].Value.ToString();
                txtSalary.Text = dataGridCashier.SelectedRows[0].Cells[3].Value.ToString();
                string[] arr = dataGridCashier.SelectedRows[0].Cells[4].Value.ToString().Split('/');
                dtDayWorking.Value = new DateTime(Convert.ToInt32(arr[2].Split(' ')[0]), Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]));
                string[] arr1 = dataGridCashier.SelectedRows[0].Cells[5].Value.ToString().Split('/');
                dtpBirthDay.Value = new DateTime(Convert.ToInt32(arr1[2].Split(' ')[0]), Convert.ToInt32(arr1[0]), Convert.ToInt32(arr1[1]));
                cbbAccountType.Text = dataGridCashier.SelectedRows[0].Cells[6].Value.ToString();
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
