﻿namespace WindowsFormsApp1
{
    partial class ControlSearchProduct
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
            this.productDGV = new System.Windows.Forms.DataGridView();
            this.comboBoxSelectCategory = new System.Windows.Forms.ComboBox();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.labelSearchProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // productDGV
            // 
            this.productDGV.AllowUserToAddRows = false;
            this.productDGV.AllowUserToDeleteRows = false;
            this.productDGV.AllowUserToResizeColumns = false;
            this.productDGV.AllowUserToResizeRows = false;
            this.productDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.GridColor = System.Drawing.SystemColors.Control;
            this.productDGV.Location = new System.Drawing.Point(28, 89);
            this.productDGV.MultiSelect = false;
            this.productDGV.Name = "productDGV";
            this.productDGV.ReadOnly = true;
            this.productDGV.RowHeadersVisible = false;
            this.productDGV.RowHeadersWidth = 51;
            this.productDGV.RowTemplate.Height = 24;
            this.productDGV.Size = new System.Drawing.Size(840, 572);
            this.productDGV.TabIndex = 2;
            this.productDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDGV_CellContentClick);
            // 
            // comboBoxSelectCategory
            // 
            this.comboBoxSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectCategory.FormattingEnabled = true;
            this.comboBoxSelectCategory.Location = new System.Drawing.Point(28, 44);
            this.comboBoxSelectCategory.Name = "comboBoxSelectCategory";
            this.comboBoxSelectCategory.Size = new System.Drawing.Size(177, 30);
            this.comboBoxSelectCategory.TabIndex = 5;
            this.comboBoxSelectCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSelectCategory_SelectionChangeCommitted);
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchProduct.Location = new System.Drawing.Point(704, 38);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.ShortcutsEnabled = false;
            this.textBoxSearchProduct.Size = new System.Drawing.Size(164, 30);
            this.textBoxSearchProduct.TabIndex = 13;
            this.textBoxSearchProduct.TextChanged += new System.EventHandler(this.textBoxSearchProduct_TextChanged);
            // 
            // labelSearchProduct
            // 
            this.labelSearchProduct.AutoSize = true;
            this.labelSearchProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchProduct.Location = new System.Drawing.Point(458, 44);
            this.labelSearchProduct.Name = "labelSearchProduct";
            this.labelSearchProduct.Size = new System.Drawing.Size(240, 22);
            this.labelSearchProduct.TabIndex = 12;
            this.labelSearchProduct.Text = "Tìm kiếm theo tên sản phẩm: ";
            // 
            // ControlSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSearchProduct);
            this.Controls.Add(this.labelSearchProduct);
            this.Controls.Add(this.comboBoxSelectCategory);
            this.Controls.Add(this.productDGV);
            this.Name = "ControlSearchProduct";
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.searchProductUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productDGV;
        private System.Windows.Forms.ComboBox comboBoxSelectCategory;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.Label labelSearchProduct;
    }
}
