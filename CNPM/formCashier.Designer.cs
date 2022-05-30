namespace WindowsFormsApp1
{
    partial class formCashier
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
            this.createBillControl1 = new WindowsFormsApp1.createBillUserControl();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonClearBill = new System.Windows.Forms.Button();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.buttonCreateBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.createBillControl1);
            this.panel1.Location = new System.Drawing.Point(188, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 673);
            this.panel1.TabIndex = 1;
            // 
            // createBillControl1
            // 
            this.createBillControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createBillControl1.Location = new System.Drawing.Point(0, 0);
            this.createBillControl1.Name = "createBillControl1";
            this.createBillControl1.Size = new System.Drawing.Size(797, 673);
            this.createBillControl1.TabIndex = 0;
            this.createBillControl1.Load += new System.EventHandler(this.createBillControl1_Load);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(12, 649);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(160, 60);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangePassword.Location = new System.Drawing.Point(12, 431);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(160, 60);
            this.buttonChangePassword.TabIndex = 4;
            this.buttonChangePassword.Text = "Đổi mật khẩu";
            this.buttonChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonClearBill
            // 
            this.buttonClearBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearBill.Location = new System.Drawing.Point(12, 331);
            this.buttonClearBill.Name = "buttonClearBill";
            this.buttonClearBill.Size = new System.Drawing.Size(160, 60);
            this.buttonClearBill.TabIndex = 3;
            this.buttonClearBill.Text = "Xoá sản phẩm";
            this.buttonClearBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClearBill.UseVisualStyleBackColor = true;
            this.buttonClearBill.Click += new System.EventHandler(this.buttonClearBill_Click);
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchProduct.Location = new System.Drawing.Point(12, 238);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(160, 60);
            this.buttonSearchProduct.TabIndex = 2;
            this.buttonSearchProduct.Text = "Tìm kiếm";
            this.buttonSearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            // 
            // buttonCreateBill
            // 
            this.buttonCreateBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateBill.Location = new System.Drawing.Point(12, 140);
            this.buttonCreateBill.Name = "buttonCreateBill";
            this.buttonCreateBill.Size = new System.Drawing.Size(160, 60);
            this.buttonCreateBill.TabIndex = 0;
            this.buttonCreateBill.Text = "Giỏ hàng";
            this.buttonCreateBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCreateBill.UseVisualStyleBackColor = true;
            this.buttonCreateBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thu ngân";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formCreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1006, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.buttonClearBill);
            this.Controls.Add(this.buttonSearchProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCreateBill);
            this.Name = "formCreateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.Button buttonClearBill;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private createBillUserControl createBillControl1;
    }
}

