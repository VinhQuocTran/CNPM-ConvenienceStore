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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNewPassword.Text = "";
            txtOldPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");

            try
            {
                cnn.Open();
                string user = txtUsername.Text;
                string oldpass = txtOldPassword.Text;
                string newpass = txtNewPassword.Text;
                using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM taikhoan WHERE tentk=@username AND matkhau=@password", cnn))
                {
                    StrQuer.Parameters.AddWithValue("@username", user);
                    StrQuer.Parameters.AddWithValue("@password", oldpass);
                    SqlDataReader dr = StrQuer.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        string query = "update taikhoan set matkhau ='" + newpass + "' where  tentk='"+user+"'";
                        SqlCommand sqlCommand = new SqlCommand(query, cnn);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Thây đổi mật khẩu thành công");
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Check your username or password");//
                    }
                }
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
