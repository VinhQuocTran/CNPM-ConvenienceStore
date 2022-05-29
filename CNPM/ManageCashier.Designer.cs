using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class ManageCashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnADDCashier = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLyCuaHangTienLoiDataSet = new WindowsFormsApp1.QuanLyCuaHangTienLoiDataSet();
            this.taikhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taikhoanTableAdapter = new WindowsFormsApp1.QuanLyCuaHangTienLoiDataSetTableAdapters.taikhoanTableAdapter();
            this.loaitkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangTienLoiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProduct.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.Green;
            this.btnProduct.Location = new System.Drawing.Point(12, 149);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(128, 69);
            this.btnProduct.TabIndex = 9;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategory.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.Green;
            this.btnCategory.Location = new System.Drawing.Point(12, 232);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(128, 66);
            this.btnCategory.TabIndex = 13;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Green;
            this.btnLogout.Location = new System.Drawing.Point(12, 498);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 67);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "AGE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "PASSWORD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "PHONE";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Aquamarine;
            this.txtName.Location = new System.Drawing.Point(325, 214);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 26);
            this.txtName.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Aquamarine;
            this.txtPhone.Location = new System.Drawing.Point(325, 306);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 26);
            this.txtPhone.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Aquamarine;
            this.txtAge.Location = new System.Drawing.Point(325, 260);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(194, 26);
            this.txtAge.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Aquamarine;
            this.txtPassword.Location = new System.Drawing.Point(325, 348);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 26);
            this.txtPassword.TabIndex = 12;
            // 
            // btnADDCashier
            // 
            this.btnADDCashier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnADDCashier.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDCashier.Location = new System.Drawing.Point(163, 411);
            this.btnADDCashier.Name = "btnADDCashier";
            this.btnADDCashier.Size = new System.Drawing.Size(118, 69);
            this.btnADDCashier.TabIndex = 14;
            this.btnADDCashier.Text = "ADD";
            this.btnADDCashier.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(287, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 68);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(398, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 68);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Aquamarine;
            this.txtID.Location = new System.Drawing.Point(325, 170);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(194, 26);
            this.txtID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(158, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN BÁN HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matkDataGridViewTextBoxColumn,
            this.tentkDataGridViewTextBoxColumn,
            this.matkhauDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.tuoiDataGridViewTextBoxColumn,
            this.loaitkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taikhoanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(525, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(455, 431);
            this.dataGridView1.TabIndex = 19;
            // 
            // quanLyCuaHangTienLoiDataSet
            // 
            this.quanLyCuaHangTienLoiDataSet.DataSetName = "QuanLyCuaHangTienLoiDataSet";
            this.quanLyCuaHangTienLoiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taikhoanBindingSource
            // 
            this.taikhoanBindingSource.DataMember = "taikhoan";
            this.taikhoanBindingSource.DataSource = this.quanLyCuaHangTienLoiDataSet;
            // 
            // taikhoanTableAdapter
            // 
            this.taikhoanTableAdapter.ClearBeforeFill = true;
            // 
            // loaitkDataGridViewTextBoxColumn
            // 
            this.loaitkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.loaitkDataGridViewTextBoxColumn.DataPropertyName = "loaitk";
            this.loaitkDataGridViewTextBoxColumn.HeaderText = "loaitk";
            this.loaitkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.loaitkDataGridViewTextBoxColumn.Name = "loaitkDataGridViewTextBoxColumn";
            this.loaitkDataGridViewTextBoxColumn.Width = 82;
            // 
            // tuoiDataGridViewTextBoxColumn
            // 
            this.tuoiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tuoiDataGridViewTextBoxColumn.DataPropertyName = "tuoi";
            this.tuoiDataGridViewTextBoxColumn.HeaderText = "tuoi";
            this.tuoiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tuoiDataGridViewTextBoxColumn.Name = "tuoiDataGridViewTextBoxColumn";
            this.tuoiDataGridViewTextBoxColumn.Width = 71;
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "hoten";
            this.hotenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            this.hotenDataGridViewTextBoxColumn.Width = 86;
            // 
            // matkhauDataGridViewTextBoxColumn
            // 
            this.matkhauDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.matkhauDataGridViewTextBoxColumn.DataPropertyName = "matkhau";
            this.matkhauDataGridViewTextBoxColumn.HeaderText = "matkhau";
            this.matkhauDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.matkhauDataGridViewTextBoxColumn.Name = "matkhauDataGridViewTextBoxColumn";
            this.matkhauDataGridViewTextBoxColumn.Width = 107;
            // 
            // tentkDataGridViewTextBoxColumn
            // 
            this.tentkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tentkDataGridViewTextBoxColumn.DataPropertyName = "tentk";
            this.tentkDataGridViewTextBoxColumn.HeaderText = "tentk";
            this.tentkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tentkDataGridViewTextBoxColumn.Name = "tentkDataGridViewTextBoxColumn";
            this.tentkDataGridViewTextBoxColumn.Width = 81;
            // 
            // matkDataGridViewTextBoxColumn
            // 
            this.matkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.matkDataGridViewTextBoxColumn.DataPropertyName = "matk";
            this.matkDataGridViewTextBoxColumn.Frozen = true;
            this.matkDataGridViewTextBoxColumn.HeaderText = "matk";
            this.matkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.matkDataGridViewTextBoxColumn.Name = "matkDataGridViewTextBoxColumn";
            this.matkDataGridViewTextBoxColumn.ReadOnly = true;
            this.matkDataGridViewTextBoxColumn.Width = 80;
            // 
            // ManageCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1007, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnADDCashier);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "ManageCashier";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.ManageCashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangTienLoiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnADDCashier;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private DataGridView dataGridView1;
        private QuanLyCuaHangTienLoiDataSet quanLyCuaHangTienLoiDataSet;
        private BindingSource taikhoanBindingSource;
        private QuanLyCuaHangTienLoiDataSetTableAdapters.taikhoanTableAdapter taikhoanTableAdapter;
        private DataGridViewTextBoxColumn matkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tentkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matkhauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaitkDataGridViewTextBoxColumn;
    }
}