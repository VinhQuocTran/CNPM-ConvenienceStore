namespace WindowsFormsApp1
{
    partial class newFormMainManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.btnCashier = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.controlChangePassword1 = new WindowsFormsApp1.ControlChangePassword();
            this.controlManageProduct1 = new WindowsFormsApp1.ControlManageProduct();
            this.controlManageCategory1 = new WindowsFormsApp1.ControlManageCategory();
            this.controlManageCashier1 = new WindowsFormsApp1.ControlManageCashier();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.NavigationPanel);
            this.panel1.Controls.Add(this.btnCashier);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 800);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.manager2;
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 79);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.SidePanel.Location = new System.Drawing.Point(213, 205);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(14, 61);
            this.SidePanel.TabIndex = 3;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = global::WindowsFormsApp1.Properties.Resources.padlock;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(3, 436);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(226, 61);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "   Đổi mật khẩu";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.NavigationPanel.Location = new System.Drawing.Point(232, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(900, 34);
            this.NavigationPanel.TabIndex = 1;
            // 
            // btnCashier
            // 
            this.btnCashier.FlatAppearance.BorderSize = 0;
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashier.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ForeColor = System.Drawing.Color.White;
            this.btnCashier.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.btnCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashier.Location = new System.Drawing.Point(3, 359);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(226, 61);
            this.btnCashier.TabIndex = 6;
            this.btnCashier.Text = "   Tài khoản";
            this.btnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::WindowsFormsApp1.Properties.Resources.category;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(3, 282);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(226, 61);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "   Danh mục";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::WindowsFormsApp1.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(5, 750);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(223, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "   Đăng xuất";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.buttonLogout_Click_1);
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::WindowsFormsApp1.Properties.Resources.product;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(3, 205);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(225, 61);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "   Sản phẩm";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.controlChangePassword1);
            this.MainPanel.Controls.Add(this.controlManageProduct1);
            this.MainPanel.Controls.Add(this.controlManageCategory1);
            this.MainPanel.Controls.Add(this.controlManageCashier1);
            this.MainPanel.Location = new System.Drawing.Point(227, 55);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(893, 696);
            this.MainPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 58);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.switch1;
            this.button1.Location = new System.Drawing.Point(834, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 53);
            this.button1.TabIndex = 3;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlChangePassword1
            // 
            this.controlChangePassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlChangePassword1.Location = new System.Drawing.Point(0, 0);
            this.controlChangePassword1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlChangePassword1.Name = "controlChangePassword1";
            this.controlChangePassword1.Size = new System.Drawing.Size(893, 696);
            this.controlChangePassword1.TabIndex = 3;
            // 
            // controlManageProduct1
            // 
            this.controlManageProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlManageProduct1.Location = new System.Drawing.Point(0, 0);
            this.controlManageProduct1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlManageProduct1.Name = "controlManageProduct1";
            this.controlManageProduct1.Size = new System.Drawing.Size(893, 696);
            this.controlManageProduct1.TabIndex = 2;
            // 
            // controlManageCategory1
            // 
            this.controlManageCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlManageCategory1.Location = new System.Drawing.Point(0, 0);
            this.controlManageCategory1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlManageCategory1.Name = "controlManageCategory1";
            this.controlManageCategory1.Size = new System.Drawing.Size(893, 696);
            this.controlManageCategory1.TabIndex = 1;
            // 
            // controlManageCashier1
            // 
            this.controlManageCashier1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlManageCashier1.Location = new System.Drawing.Point(0, 0);
            this.controlManageCashier1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlManageCashier1.Name = "controlManageCashier1";
            this.controlManageCashier1.Size = new System.Drawing.Size(893, 696);
            this.controlManageCashier1.TabIndex = 0;
            // 
            // newFormMainManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newFormMainManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newFormMainCashier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private ControlChangePassword controlChangePassword1;
        private ControlManageProduct controlManageProduct1;
        private ControlManageCategory controlManageCategory1;
        private ControlManageCashier controlManageCashier1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}