using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=QuanLyCuaHangTienLoi;Trusted_Connection=True");
        private void btnADDCashier_Click(object sender, EventArgs e)
        {
            try{
                cnn.Open();
                string query = "insert into danhmuc values('" + txtID.Text +"','"+ txtName.Text +"','"+ txtDescription.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query,cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Add Category successful");
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";

        }
        private void showDataGrid()
        {
            cnn.Open();
            string query = "select * from danhmuc";
            SqlDataAdapter sqlDataAdapter= new SqlDataAdapter(query, cnn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridCategoy.DataSource = dataSet.Tables[0];
            cnn.Close();
        }
        private void ManageCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangTienLoiDataSet.danhmuc' table. You can move, or remove it, as needed.
            showDataGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showDataGrid();
        }

        private void dataGridCategoy_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridCategoy.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridCategoy.SelectedRows[0].Cells[1].Value.ToString();
            txtDescription.Text = dataGridCategoy.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string query = "delete danhmuc where madanhmuc = '"+txtID.Text+"'";
                SqlCommand sqlCommand = new SqlCommand(query, cnn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Remove Category successful");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlManage controlManage = new ControlManage();
            controlManage.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string query = "select * from danhmuc where madanhmuc = '"+ txtID.Text + "' or (  tendanhmuc  like N'%"+ txtName.Text + "%' and tendanhmuc not like N'')";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, cnn);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridCategoy.DataSource = dataSet.Tables[0];
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
