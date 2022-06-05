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
    public partial class ControlChangePassword : UserControl
    {
        public ControlChangePassword()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");


        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string oldpass = txtOldPassword.Text;
                string username = txtUserName.Text;
                string newpass = txtNewPassword.Text;
                string new2pass = txt2NewPassword.Text;
                if (!newpass.Equals(new2pass))
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu mới");
                }
                else
                {
                    using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM taikhoan WHERE matkhau=@password and tentk = @username", cnn))
                    {
                        StrQuer.Parameters.AddWithValue("@password", oldpass);
                        StrQuer.Parameters.AddWithValue("@username", username);
                        FormLogin login = new FormLogin();

                        SqlDataReader dr = StrQuer.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Close();
                            string query = "update taikhoan set matkhau ='" + newpass + "' where  tentk='" + username + "'";
                            SqlCommand sqlCommand = new SqlCommand(query, cnn);
                            sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Thay đổi mật khẩu thành công");
                            //var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "newFormMainCashier" || x.Name == "newFormMainManager").FirstOrDefault();
                            //if (null != frm)
                            //{
                            //    frm.Hide();
                            //}
                            foreach (Form form in Application.OpenForms)
                            {
                                if (form is FormManager || form is FormCashier)
                                {
                                    form.Hide();
                                }
                            }
                            this.Hide();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đúng mật khẩu cũ");
                        }
                    }
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtNewPassword.Text = "";
            txtOldPassword.Text = "";
        }
    }
}
