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
    public partial class ControlCreateBill : UserControl
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");

        private void populateProduct()
        {
            con.Open();
            string query = "SELECT masp,tensp as \"Tên Sản Phẩm\",giaban as \"Giá bán\",donvitinh,hangtrongkho from sanpham";
            var sda = new SqlDataAdapter(query, con);
            var builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();

            sda.Fill(dataSet);
            productDGV.DataSource = dataSet.Tables[0];
            productDGV.Columns[0].Visible = false;
            productDGV.Columns[3].Visible = false;
            productDGV.Columns[4].Visible = false;
            con.Close();
        }

        private void populateBill()
        {
            con.Open();
            string query = "SELECT mahd as \"Mã hoá đơn\",convert(varchar,ngayxuat,22) as \"Giờ bán\",tongtien as \"Tổng tiền\",hoten as \"Người bán\" from hoadon hd inner join taikhoan tk on hd.nguoiban=tk.matk where day(ngayxuat)=day(getdate())";
            var sda = new SqlDataAdapter(query, con);
            var builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();

            sda.Fill(dataSet);
            billDGV.DataSource = dataSet.Tables[0];
            con.Close();
        }

        public ControlCreateBill()
        {
            InitializeComponent();
            //searchProductUserControl fr2 = new searchProductUserControl(this);

            // Setting for Selecting Product Data Grid View in CreateBill
            populateProduct();
            productDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productDGV.EnableHeadersVisualStyles = false;
            productDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCoral;
            productDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightCoral;


            //// Setting for Bill Data Grid View in CreateBill
            populateBill();
            billDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            billDGV.EnableHeadersVisualStyles = false;
            billDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            billDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCoral;
            billDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightCoral;

            // Setting for Product Cart Data Grid View in CreateBill
            orderDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderDGV.EnableHeadersVisualStyles = false;
            orderDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            orderDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCoral;
            orderDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightCoral;
        }



        private void CreateBillControl_Load(object sender, EventArgs e)
        {
            fillComboBox();
        }

        private void productDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelProId.Text = productDGV.SelectedRows[0].Cells[0].Value.ToString();
            labelProName.Text = productDGV.SelectedRows[0].Cells[1].Value.ToString();
            labelProPrice.Text = productDGV.SelectedRows[0].Cells[2].Value.ToString();
            labelProUnit.Text = productDGV.SelectedRows[0].Cells[3].Value.ToString();
            labelProQuantity.Text = productDGV.SelectedRows[0].Cells[4].Value.ToString();
        }


        public static double totalCart = 0;
        public static int n = 1;
        public void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (labelProName.Text.Length == 0 || textBoxProQuantity.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng");
            else
            {
                decimal inventory = decimal.Parse(labelProQuantity.Text);
                decimal quantity = decimal.Parse(textBoxProQuantity.Text);

                if (quantity <= 0)
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                else if (quantity > inventory)
                    MessageBox.Show("Hàng trong kho không đủ để thêm vào giỏ");
                else
                {

                    // Check if product exists in cart or not 
                    bool flagProductExist = false;
                    foreach (DataGridViewRow row in orderDGV.Rows)
                    {
                        string tmp = row.Cells[5].Value.ToString();
                        if (tmp == labelProId.Text)
                            flagProductExist = true;
                    }

                    if(flagProductExist)
                        MessageBox.Show("Sản phẩm đã tồn tại trong giỏ\nNếu muốn thay đổi số lượng vui lòng bỏ sản phẩm ra khỏi giỏ và thêm lại");
                    else
                    {
                        inventory = decimal.Round(inventory, 2);
                        quantity = decimal.Round(quantity, 2);
                        double totalEachProduct = Convert.ToDouble(labelProPrice.Text) * Convert.ToDouble(textBoxProQuantity.Text);

                        // Create new row in cart for new product
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(orderDGV);
                        newRow.Cells[0].Value = n++;
                        newRow.Cells[1].Value = labelProName.Text;
                        newRow.Cells[2].Value = labelProPrice.Text;
                        newRow.Cells[3].Value = textBoxProQuantity.Text;
                        newRow.Cells[4].Value = Convert.ToDouble(labelProPrice.Text) * Convert.ToDouble(textBoxProQuantity.Text);
                        newRow.Cells[5].Value = labelProId.Text;
                        orderDGV.Rows.Add(newRow);

                        // Update total price of cart
                        totalCart += totalEachProduct;
                        labelCartTotal.Text = totalCart.ToString();
                    }
                }
            }
            //labelCartTotal.Text += 'VNĐ';
        }

        private void textBoxProQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
                e.Handled = true;

            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
                e.Handled = true;
        }

        private void orderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clearCartDGV()
        {
            this.orderDGV.Rows.Clear();
            this.orderDGV.Refresh();
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

            sqlReader.Close();
            con.Close();
        }

        private void comboBoxSelectCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string catName = comboBoxSelectCategory.GetItemText(comboBoxSelectCategory.SelectedItem);
            //MessageBox.Show(comboBoxSelectCategory.GetItemText(comboBoxSelectCategory.SelectedItem));
            string query="";
            if (catName=="Tat ca")
                query = "SELECT masp,tensp as \"Tên Sản Phẩm\",giaban as \"Giá bán\",donvitinh,hangtrongkho from sanpham sp inner join danhmuc dm on dm.madanhmuc=sp.madanhmuc";
            else
                query = "SELECT masp,tensp as \"Tên Sản Phẩm\",giaban as \"Giá bán\",donvitinh,hangtrongkho from sanpham sp inner join danhmuc dm on dm.madanhmuc=sp.madanhmuc where dm.tendanhmuc=\'" + catName + "\'";
            var sda = new SqlDataAdapter(query, con);
            var builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();

            sda.Fill(dataSet);
            productDGV.DataSource = dataSet.Tables[0];
            con.Close();
        }

        private void buttonAddBill_Click(object sender, EventArgs e)
        {
            if(orderDGV.Rows.Count==0)
                MessageBox.Show("Giỏ hàng trống, không thể thanh toán");
            else
            {
                string time = "\'" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "\'";
                string query = "insert into hoadon values (" + time + "," + totalCart + "," + formLogin.matk+")";
                //MessageBox.Show(query);

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill Created successfully");

                
                foreach (DataGridViewRow row in orderDGV.Rows)
                {
                    // Update new quantity of each product after bill created
                    string proId = row.Cells[5].Value.ToString();
                    string quantity = row.Cells[3].Value.ToString();
                    query = "update sanpham set hangtrongkho=hangtrongkho-" + quantity + " where masp=\'" + proId + "\'";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show(quantity);

                    // Get lastet mahd from bill
                    query = "select top 1 mahd from hoadon order by ngayxuat desc";
                    cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    string mahd="";
                    while(dr.Read())
                    {
                        mahd = dr["mahd"].ToString();
                    }
                    dr.Close();

                    // Insert into chitiethoadon
                    string price = row.Cells[2].Value.ToString();
                    query = "insert into chitiethoadon values (" + mahd + "," + "\'"+proId + "\'" + "," + quantity + "," + price + ")";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }


                // Reset total cart after bill created
                totalCart = 0;
                labelCartTotal.Text = totalCart.ToString();
                orderDGV.Rows.Clear();
                n = 1;
                con.Close();

                // Refresh BillDGV to show order
                populateBill();
                populateProduct();
                labelProQuantity.Text = "";
                labelProName.Text = "";
                labelProUnit.Text = "";
                labelProQuantity.Text = "";
            }
        }

        private void buttonDeleteProductFromCart_Click(object sender, EventArgs e)
        {
            if (orderDGV.SelectedRows.Count == 0)
                MessageBox.Show("Vui lòng chọn sản phẩm để xoá");
            else
            {
                // Update total price of cart when removing product
                double totalPrice = Convert.ToDouble(orderDGV.SelectedRows[0].Cells[4].Value.ToString());
                totalCart -= totalPrice;
                labelCartTotal.Text = totalCart.ToString();

                // Remove product from cart
                int rowIndex = orderDGV.CurrentCell.RowIndex;
                orderDGV.Rows.RemoveAt(rowIndex);

                // Iterate each row and update index
                int i = 1;
                foreach (DataGridViewRow row in orderDGV.Rows)
                {
                    row.Cells[0].Value = i++;
                    //More code here
                }
                n = i;

                // Update quantity available of product
                //double quantity = Convert.ToDouble(orderDGV.SelectedRows[0].Cells[3].Value.ToString());
                //string name = orderDGV.SelectedRows[0].Cells[1].Value.ToString();
                //string query = "update sanpham set hangtrongkho=hangtrongkho+" + quantity.ToString() + " where tensp=\'" + name+"\'";
                //con.Open();
                //SqlCommand cmd = new SqlCommand(query, con);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Product Removed Successfully");
                //con.Close();
                //MessageBox.Show(query);
            }

        }

        private void buttonPrintBill_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender,System.Drawing.Printing.PrintPageEventArgs e)
        {
            string mahd= billDGV.SelectedRows[0].Cells[0].Value.ToString();
            string ngayxuat = billDGV.SelectedRows[0].Cells[1].Value.ToString();
            string tongtien = string.Format("{0:0,0}", billDGV.SelectedRows[0].Cells[2].Value);


            e.Graphics.DrawString("CỬA HÀNG TIỆN LỢI", new Font("Arial", 25, FontStyle.Bold), Brushes.Green, new Point(300));
            e.Graphics.DrawString("Mã hoá đơn: "+mahd, new Font("Arial", 16, FontStyle.Bold), Brushes.Blue, new Point(100,150));
            e.Graphics.DrawString("Ngày xuất: " +ngayxuat, new Font("Arial", 16, FontStyle.Bold), Brushes.Blue, new Point(100, 200));
            e.Graphics.DrawString("Tổng hoá đơn: "+ tongtien + " VNĐ", new Font("Arial", 16, FontStyle.Bold), Brushes.Blue, new Point(100, 250));
            e.Graphics.DrawString("Chi Tiết: ", new Font("Arial", 16, FontStyle.Bold), Brushes.Blue, new Point(100, 300));

            con.Open();
            string query = "select tensp,soluong,cthd.giaban as gia,soluong*cthd.giaban as tong from chitiethoadon cthd inner join sanpham sp on sp.masp=cthd.masp where mahd="+ mahd;
            var cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int x = 0;
            while (dr.Read())
            {
                string name= "Tên: "+dr["tensp"].ToString();
                string quantity= "Số lượng: " + dr["soluong"].ToString();
                string price= "Giá: " + dr["gia"].ToString();
                string total= "Tổng : " + dr["tong"].ToString();
                e.Graphics.DrawString(name+", "+ quantity + ", " + price + ", " + total, new Font("Arial", 12, FontStyle.Bold), Brushes.Blue, new Point(120, 350+50*x));
                x++;
            }
            dr.Close();
            con.Close();
        }
    }
}
