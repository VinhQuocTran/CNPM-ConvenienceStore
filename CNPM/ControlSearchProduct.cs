using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ControlSearchProduct : UserControl
    {

        public ControlSearchProduct()
        {
            InitializeComponent();
            //this.createBillControl = tmp;

            populateProduct();
            productDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productDGV.EnableHeadersVisualStyles = false;
            productDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCoral;
            productDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightCoral;
        }

        //public searchProductUserControl(createBillUserControl tmp)
        //{
        //    InitializeComponent();
        //    this.createBillControl = tmp;
        //}

        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");

        public void populateProduct()
        {
            con.Open();
            string query = "SELECT sp.masp,tensp as \"Tên Sản Phẩm\",tendanhmuc as \"Tên danh mục\",giaban as \"Giá bán\",donvitinh as \"Đơn vị tính\",hangtrongkho as \"Hàng trong kho\" from sanpham sp inner join danhmuc dm on dm.madanhmuc=sp.madanhmuc";
            var sda = new SqlDataAdapter(query, con);
            var builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();

            sda.Fill(dataSet);
            productDGV.DataSource = dataSet.Tables[0];
            productDGV.Columns[0].Visible = false;
            //productDGV.Columns[3].Visible = false;
            //productDGV.Columns[4].Visible = false;
            con.Close();
        }

        private void fillComboBox()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM danhmuc", con);
            con.Open();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            comboBoxSelectCategory.Items.Add("Tat ca");
            while (sqlReader.Read())
            {
                comboBoxSelectCategory.Items.Add(sqlReader["tendanhmuc"].ToString());
            }
            comboBoxSelectCategory.SelectedItem = "Tat ca";

            sqlReader.Close();
            con.Close();
        }


        private void productDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchProductUserControl_Load(object sender, EventArgs e)
        {
            fillComboBox();
        }

        private void comboBoxSelectCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string catName = comboBoxSelectCategory.GetItemText(comboBoxSelectCategory.SelectedItem);
            //MessageBox.Show(comboBoxSelectCategory.GetItemText(comboBoxSelectCategory.SelectedItem));
            string query = "";
            if (catName == "Tat ca")
                query = "SELECT sp.masp,tensp as \"Tên Sản Phẩm\",tendanhmuc as \"Tên danh mục\",giaban as \"Giá bán\",donvitinh as \"Đơn vị tính\",round(hangtrongkho,2) as \"Hàng trong kho\" from sanpham sp inner join danhmuc dm on dm.madanhmuc=sp.madanhmuc";
            else
                query = "SELECT sp.masp,tensp as \"Tên Sản Phẩm\",tendanhmuc as \"Tên danh mục\",giaban as \"Giá bán\",donvitinh as \"Đơn vị tính\",round(hangtrongkho,2) as \"Hàng trong kho\" from sanpham sp inner join danhmuc dm on dm.madanhmuc=sp.madanhmuc where dm.tendanhmuc=\'" + catName + "\'";
            var sda = new SqlDataAdapter(query, con);
            var builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();

            sda.Fill(dataSet);
            productDGV.DataSource = dataSet.Tables[0];
            con.Close();
        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "";
            string catName = comboBoxSelectCategory.GetItemText(comboBoxSelectCategory.SelectedItem);


            if (textBoxSearchProduct.Text.Length == 0 && catName=="Tat ca")
                query = "SELECT sp.masp,tensp as \"Tên Sản Phẩm\",tendanhmuc as \"Tên danh mục\",giaban as \"Giá bán\",donvitinh as \"Đơn vị tính\",round(hangtrongkho,2) as \"Hàng trong kho\" from sanpham sp inner join danhmuc dm on dm.madanhmuc=sp.madanhmuc";
            else if(textBoxSearchProduct.Text.Length > 0 && catName == "Tat ca")
                query = "SELECT sp.masp,tensp as \"Tên Sản Phẩm\",tendanhmuc as \"Tên danh mục\",giaban as \"Giá bán\",donvitinh as \"Đơn vị tính\",round(hangtrongkho,2) as \"Hàng trong kho\" from sanpham sp inner join danhmuc dm on dm.madanhmuc=sp.madanhmuc where " + "tensp like \'" + textBoxSearchProduct.Text + "%\'";
            else
                query = "SELECT masp,tensp as \"Tên Sản Phẩm\",giaban as \"Giá bán\",donvitinh,hangtrongkho from sanpham sp inner join danhmuc dm on dm.madanhmuc=sp.madanhmuc where dm.tendanhmuc=\'" + catName + "\'" + "and tensp like \'" + textBoxSearchProduct.Text + "%\'";
            
            var sda = new SqlDataAdapter(query, con);
            var builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            productDGV.DataSource = dataSet.Tables[0];
            con.Close();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            ControlCreateBill control = new ControlCreateBill();
            control.clearCartDGV();
        }
    }
}
