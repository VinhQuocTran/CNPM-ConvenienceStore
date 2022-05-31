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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");

            cnn.Open();
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM taikhoan WHERE tentk=@username AND matk=@password", cnn))
                {
                    StrQuer.Parameters.AddWithValue("@username", user);
                    StrQuer.Parameters.AddWithValue("@password", pass);
                    SqlDataReader dr = StrQuer.ExecuteReader();
                    if(dr.HasRows)
                    {
                        MessageBox.Show("loginSuccess");
                    }
                    else
                    {
                        MessageBox.Show("Check your username or password");
                    }
                }
                cnn.Close();
         
        }
    }
}
