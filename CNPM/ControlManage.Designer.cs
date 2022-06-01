namespace WindowsFormsApp1
{
    partial class ControlManage
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
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.controlManageProduct1 = new WindowsFormsApp1.ControlManageProduct();
            this.controlManageCategory1 = new WindowsFormsApp1.ControlManageCategory();
            this.controlManageCashier1 = new WindowsFormsApp1.ControlManageCashier();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(3, 162);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(158, 55);
            this.btnProduct.TabIndex = 8;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.controlManageCashier1);
            this.panel1.Controls.Add(this.controlManageCategory1);
            this.panel1.Controls.Add(this.controlManageProduct1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(166, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 923);
            this.panel1.TabIndex = 7;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(3, 235);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(158, 55);
            this.btnCategory.TabIndex = 9;
            this.btnCategory.Text = "Danh mục";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.Location = new System.Drawing.Point(3, 312);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(158, 55);
            this.btnCashier.TabIndex = 10;
            this.btnCashier.Text = "Nhân viên";
            this.btnCashier.UseVisualStyleBackColor = false;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(3, 392);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 55);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // controlManageProduct1
            // 
            this.controlManageProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlManageProduct1.Location = new System.Drawing.Point(0, 0);
            this.controlManageProduct1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.controlManageProduct1.Name = "controlManageProduct1";
            this.controlManageProduct1.Size = new System.Drawing.Size(1350, 923);
            this.controlManageProduct1.TabIndex = 0;
            // 
            // controlManageCategory1
            // 
            this.controlManageCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlManageCategory1.Location = new System.Drawing.Point(0, 0);
            this.controlManageCategory1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.controlManageCategory1.Name = "controlManageCategory1";
            this.controlManageCategory1.Size = new System.Drawing.Size(1350, 923);
            this.controlManageCategory1.TabIndex = 1;
            // 
            // controlManageCashier1
            // 
            this.controlManageCashier1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlManageCashier1.Location = new System.Drawing.Point(0, 0);
            this.controlManageCashier1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.controlManageCashier1.Name = "controlManageCashier1";
            this.controlManageCashier1.Size = new System.Drawing.Size(1350, 923);
            this.controlManageCashier1.TabIndex = 2;
            // 
            // ControlManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1512, 1050);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCategory);
            this.Name = "ControlManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlManage";
            this.Load += new System.EventHandler(this.ControlManage_Load_1);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Button btnLogout;
        private ControlManageProduct controlManageProduct1;
        private ControlManageCashier controlManageCashier1;
        private ControlManageCategory controlManageCategory1;
    }
}