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
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(167, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 668);
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
            this.btnCashier.Size = new System.Drawing.Size(158, 56);
            this.btnCashier.TabIndex = 10;
            this.btnCashier.Text = "Nhân viên";
            this.btnCashier.UseVisualStyleBackColor = false;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // ControlManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1314, 740);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCategory);
            this.Name = "ControlManage";
            this.Text = "ControlManage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnCashier;
    }
}