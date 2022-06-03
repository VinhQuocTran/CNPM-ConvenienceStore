namespace WindowsFormsApp1
{
    partial class ControlManageCashier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbAccountType = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnADDCashier = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.dtDayWorking = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridCashier = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(642, 252);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 60);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "SỬA";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Aquamarine;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(702, 190);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 35);
            this.txtPassword.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 48;
            this.label2.Text = "LOẠI";
            // 
            // cbbAccountType
            // 
            this.cbbAccountType.BackColor = System.Drawing.Color.White;
            this.cbbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAccountType.ForeColor = System.Drawing.Color.SpringGreen;
            this.cbbAccountType.FormattingEnabled = true;
            this.cbbAccountType.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cbbAccountType.Location = new System.Drawing.Point(238, 200);
            this.cbbAccountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAccountType.Name = "cbbAccountType";
            this.cbbAccountType.Size = new System.Drawing.Size(173, 35);
            this.cbbAccountType.TabIndex = 45;
            this.cbbAccountType.UseWaitCursor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(479, 254);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 60);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnADDCashier
            // 
            this.btnADDCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.btnADDCashier.FlatAppearance.BorderSize = 0;
            this.btnADDCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDCashier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDCashier.ForeColor = System.Drawing.Color.Black;
            this.btnADDCashier.Location = new System.Drawing.Point(795, 252);
            this.btnADDCashier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADDCashier.Name = "btnADDCashier";
            this.btnADDCashier.Size = new System.Drawing.Size(135, 60);
            this.btnADDCashier.TabIndex = 41;
            this.btnADDCashier.Text = "THÊM";
            this.btnADDCashier.UseVisualStyleBackColor = false;
            this.btnADDCashier.Click += new System.EventHandler(this.btnADDCashier_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Aquamarine;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(702, 140);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 35);
            this.txtUsername.TabIndex = 38;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Aquamarine;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(238, 102);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 35);
            this.txtName.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 27);
            this.label8.TabIndex = 36;
            this.label8.Text = "TÊN TÀI KHOẢN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "MẬT KHẨU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "NGÀY SINH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "TÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpBirthDay);
            this.panel1.Controls.Add(this.dtDayWorking);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridCashier);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbAccountType);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnADDCashier);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 870);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(934, 55);
            this.label9.TabIndex = 78;
            this.label9.Text = "QUẢN LÝ TÀI KHOẢN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDay.Location = new System.Drawing.Point(238, 154);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(173, 35);
            this.dtpBirthDay.TabIndex = 60;
            this.dtpBirthDay.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            // 
            // dtDayWorking
            // 
            this.dtDayWorking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDayWorking.Location = new System.Drawing.Point(702, 92);
            this.dtDayWorking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDayWorking.Name = "dtDayWorking";
            this.dtDayWorking.Size = new System.Drawing.Size(173, 35);
            this.dtDayWorking.TabIndex = 59;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Aquamarine;
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(238, 252);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(173, 35);
            this.txtSalary.TabIndex = 58;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProQuantity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 27);
            this.label5.TabIndex = 56;
            this.label5.Text = "NGÀY NHẬN VIỆC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 27);
            this.label4.TabIndex = 55;
            this.label4.Text = " MỨC LƯƠNG";
            // 
            // dataGridCashier
            // 
            this.dataGridCashier.AllowUserToAddRows = false;
            this.dataGridCashier.AllowUserToDeleteRows = false;
            this.dataGridCashier.AllowUserToResizeColumns = false;
            this.dataGridCashier.AllowUserToResizeRows = false;
            this.dataGridCashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCashier.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCashier.Location = new System.Drawing.Point(26, 431);
            this.dataGridCashier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridCashier.Name = "dataGridCashier";
            this.dataGridCashier.ReadOnly = true;
            this.dataGridCashier.RowHeadersVisible = false;
            this.dataGridCashier.RowHeadersWidth = 62;
            this.dataGridCashier.RowTemplate.Height = 28;
            this.dataGridCashier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCashier.Size = new System.Drawing.Size(904, 330);
            this.dataGridCashier.TabIndex = 54;
            this.dataGridCashier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCashier_CellClick);
            // 
            // ControlManageCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ControlManageCashier";
            this.Size = new System.Drawing.Size(1005, 870);
            this.Load += new System.EventHandler(this.ControlManageCashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbAccountType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnADDCashier;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridCashier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtDayWorking;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Label label9;
    }
}
