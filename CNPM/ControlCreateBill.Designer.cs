﻿namespace WindowsFormsApp1
{
    partial class ControlCreateBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCreateBill));
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.comboBoxSelectCategory = new System.Windows.Forms.ComboBox();
            this.labelProductUnit = new System.Windows.Forms.Label();
            this.labelProductEnterQuantity = new System.Windows.Forms.Label();
            this.labelProName = new System.Windows.Forms.Label();
            this.labelProUnit = new System.Windows.Forms.Label();
            this.labelProPrice = new System.Windows.Forms.Label();
            this.textBoxProQuantity = new System.Windows.Forms.TextBox();
            this.labelProQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCartTotal = new System.Windows.Forms.Label();
            this.buttonAddBill = new System.Windows.Forms.Button();
            this.buttonPrintBill = new System.Windows.Forms.Button();
            this.buttonDeleteProductFromCart = new System.Windows.Forms.Button();
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProId = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.productDGV = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(18, 55);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(118, 22);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Tên sản phẩm";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductPrice.Location = new System.Drawing.Point(18, 140);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(72, 22);
            this.labelProductPrice.TabIndex = 3;
            this.labelProductPrice.Text = "Giá bán";
            // 
            // comboBoxSelectCategory
            // 
            this.comboBoxSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCategory.FormattingEnabled = true;
            this.comboBoxSelectCategory.Location = new System.Drawing.Point(22, 343);
            this.comboBoxSelectCategory.Name = "comboBoxSelectCategory";
            this.comboBoxSelectCategory.Size = new System.Drawing.Size(177, 24);
            this.comboBoxSelectCategory.TabIndex = 4;
            this.comboBoxSelectCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSelectCategory_SelectionChangeCommitted);
            // 
            // labelProductUnit
            // 
            this.labelProductUnit.AutoSize = true;
            this.labelProductUnit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductUnit.Location = new System.Drawing.Point(18, 98);
            this.labelProductUnit.Name = "labelProductUnit";
            this.labelProductUnit.Size = new System.Drawing.Size(99, 22);
            this.labelProductUnit.TabIndex = 5;
            this.labelProductUnit.Text = "Đơn vị tính";
            // 
            // labelProductEnterQuantity
            // 
            this.labelProductEnterQuantity.AutoSize = true;
            this.labelProductEnterQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductEnterQuantity.Location = new System.Drawing.Point(18, 226);
            this.labelProductEnterQuantity.Name = "labelProductEnterQuantity";
            this.labelProductEnterQuantity.Size = new System.Drawing.Size(126, 22);
            this.labelProductEnterQuantity.TabIndex = 6;
            this.labelProductEnterQuantity.Text = "Nhập số lượng";
            // 
            // labelProName
            // 
            this.labelProName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProName.Location = new System.Drawing.Point(169, 49);
            this.labelProName.Name = "labelProName";
            this.labelProName.Size = new System.Drawing.Size(156, 25);
            this.labelProName.TabIndex = 8;
            this.labelProName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProUnit
            // 
            this.labelProUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProUnit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProUnit.Location = new System.Drawing.Point(169, 92);
            this.labelProUnit.Name = "labelProUnit";
            this.labelProUnit.Size = new System.Drawing.Size(156, 25);
            this.labelProUnit.TabIndex = 9;
            this.labelProUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProPrice
            // 
            this.labelProPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProPrice.Location = new System.Drawing.Point(169, 134);
            this.labelProPrice.Name = "labelProPrice";
            this.labelProPrice.Size = new System.Drawing.Size(156, 25);
            this.labelProPrice.TabIndex = 10;
            this.labelProPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProQuantity
            // 
            this.textBoxProQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProQuantity.Location = new System.Drawing.Point(170, 223);
            this.textBoxProQuantity.Name = "textBoxProQuantity";
            this.textBoxProQuantity.ShortcutsEnabled = false;
            this.textBoxProQuantity.Size = new System.Drawing.Size(156, 30);
            this.textBoxProQuantity.TabIndex = 11;
            this.textBoxProQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProQuantity_KeyPress);
            // 
            // labelProQuantity
            // 
            this.labelProQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProQuantity.Location = new System.Drawing.Point(169, 175);
            this.labelProQuantity.Name = "labelProQuantity";
            this.labelProQuantity.Size = new System.Drawing.Size(156, 25);
            this.labelProQuantity.TabIndex = 13;
            this.labelProQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hàng trong kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giỏ hàng";
            // 
            // orderDGV
            // 
            this.orderDGV.AllowUserToAddRows = false;
            this.orderDGV.AllowUserToDeleteRows = false;
            this.orderDGV.AllowUserToResizeColumns = false;
            this.orderDGV.AllowUserToResizeRows = false;
            this.orderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.quantity,
            this.total,
            this.ProId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderDGV.GridColor = System.Drawing.SystemColors.Control;
            this.orderDGV.Location = new System.Drawing.Point(386, 55);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.ReadOnly = true;
            this.orderDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderDGV.RowHeadersVisible = false;
            this.orderDGV.RowHeadersWidth = 51;
            this.orderDGV.RowTemplate.Height = 24;
            this.orderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDGV.Size = new System.Drawing.Size(492, 242);
            this.orderDGV.TabIndex = 15;
            this.orderDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDGV_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Thứ tự";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Tên sản phẩm";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Giá sản phẩm";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Tổng";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // ProId
            // 
            this.ProId.HeaderText = "MaSP";
            this.ProId.MinimumWidth = 6;
            this.ProId.Name = "ProId";
            this.ProId.ReadOnly = true;
            this.ProId.Visible = false;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.buttonAddProduct.FlatAppearance.BorderSize = 0;
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.Location = new System.Drawing.Point(170, 274);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(156, 46);
            this.buttonAddProduct.TabIndex = 16;
            this.buttonAddProduct.Text = "Thêm vào giỏ";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng tiền:";
            // 
            // labelCartTotal
            // 
            this.labelCartTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCartTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartTotal.Location = new System.Drawing.Point(719, 310);
            this.labelCartTotal.Name = "labelCartTotal";
            this.labelCartTotal.Size = new System.Drawing.Size(159, 25);
            this.labelCartTotal.TabIndex = 18;
            this.labelCartTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddBill
            // 
            this.buttonAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.buttonAddBill.FlatAppearance.BorderSize = 0;
            this.buttonAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBill.Location = new System.Drawing.Point(544, 642);
            this.buttonAddBill.Name = "buttonAddBill";
            this.buttonAddBill.Size = new System.Drawing.Size(131, 55);
            this.buttonAddBill.TabIndex = 19;
            this.buttonAddBill.Text = "Thanh toán";
            this.buttonAddBill.UseVisualStyleBackColor = false;
            this.buttonAddBill.Click += new System.EventHandler(this.buttonAddBill_Click);
            // 
            // buttonPrintBill
            // 
            this.buttonPrintBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.buttonPrintBill.FlatAppearance.BorderSize = 0;
            this.buttonPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintBill.Location = new System.Drawing.Point(747, 642);
            this.buttonPrintBill.Name = "buttonPrintBill";
            this.buttonPrintBill.Size = new System.Drawing.Size(131, 55);
            this.buttonPrintBill.TabIndex = 20;
            this.buttonPrintBill.Text = "In hoá đơn";
            this.buttonPrintBill.UseVisualStyleBackColor = false;
            this.buttonPrintBill.Click += new System.EventHandler(this.buttonPrintBill_Click);
            // 
            // buttonDeleteProductFromCart
            // 
            this.buttonDeleteProductFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(170)))), ((int)(((byte)(26)))));
            this.buttonDeleteProductFromCart.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProductFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProductFromCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteProductFromCart.Location = new System.Drawing.Point(386, 301);
            this.buttonDeleteProductFromCart.Name = "buttonDeleteProductFromCart";
            this.buttonDeleteProductFromCart.Size = new System.Drawing.Size(157, 34);
            this.buttonDeleteProductFromCart.TabIndex = 21;
            this.buttonDeleteProductFromCart.Text = "Xoá khỏi giỏ";
            this.buttonDeleteProductFromCart.UseVisualStyleBackColor = false;
            this.buttonDeleteProductFromCart.Click += new System.EventHandler(this.buttonDeleteProductFromCart_Click);
            // 
            // billDGV
            // 
            this.billDGV.AllowUserToAddRows = false;
            this.billDGV.AllowUserToDeleteRows = false;
            this.billDGV.AllowUserToResizeColumns = false;
            this.billDGV.AllowUserToResizeRows = false;
            this.billDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.billDGV.GridColor = System.Drawing.SystemColors.Control;
            this.billDGV.Location = new System.Drawing.Point(386, 393);
            this.billDGV.MultiSelect = false;
            this.billDGV.Name = "billDGV";
            this.billDGV.ReadOnly = true;
            this.billDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.billDGV.RowHeadersVisible = false;
            this.billDGV.RowHeadersWidth = 51;
            this.billDGV.RowTemplate.Height = 24;
            this.billDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDGV.Size = new System.Drawing.Size(492, 196);
            this.billDGV.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Hoá đơn bán trong ngày";
            // 
            // labelProId
            // 
            this.labelProId.AutoSize = true;
            this.labelProId.Location = new System.Drawing.Point(166, 32);
            this.labelProId.Name = "labelProId";
            this.labelProId.Size = new System.Drawing.Size(45, 17);
            this.labelProId.TabIndex = 24;
            this.labelProId.Text = "MãSP";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // productDGV
            // 
            this.productDGV.AllowUserToAddRows = false;
            this.productDGV.AllowUserToDeleteRows = false;
            this.productDGV.AllowUserToResizeColumns = false;
            this.productDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            this.productDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.productDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.productDGV.GridColor = System.Drawing.SystemColors.Control;
            this.productDGV.Location = new System.Drawing.Point(22, 373);
            this.productDGV.MultiSelect = false;
            this.productDGV.Name = "productDGV";
            this.productDGV.ReadOnly = true;
            this.productDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productDGV.RowHeadersVisible = false;
            this.productDGV.RowHeadersWidth = 51;
            this.productDGV.RowTemplate.Height = 24;
            this.productDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDGV.Size = new System.Drawing.Size(304, 324);
            this.productDGV.TabIndex = 1;
            this.productDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDGV_CellClick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog2";
            this.printPreviewDialog1.Visible = false;
            // 
            // ControlCreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelProId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.billDGV);
            this.Controls.Add(this.buttonDeleteProductFromCart);
            this.Controls.Add(this.buttonPrintBill);
            this.Controls.Add(this.buttonAddBill);
            this.Controls.Add(this.labelCartTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.orderDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProQuantity);
            this.Controls.Add(this.labelProPrice);
            this.Controls.Add(this.labelProUnit);
            this.Controls.Add(this.labelProName);
            this.Controls.Add(this.labelProductEnterQuantity);
            this.Controls.Add(this.labelProductUnit);
            this.Controls.Add(this.comboBoxSelectCategory);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.productDGV);
            this.Controls.Add(this.labelProductName);
            this.Name = "ControlCreateBill";
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.CreateBillControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.ComboBox comboBoxSelectCategory;
        private System.Windows.Forms.Label labelProductUnit;
        private System.Windows.Forms.Label labelProductEnterQuantity;
        private System.Windows.Forms.Label labelProName;
        private System.Windows.Forms.Label labelProUnit;
        private System.Windows.Forms.Label labelProPrice;
        private System.Windows.Forms.TextBox textBoxProQuantity;
        private System.Windows.Forms.Label labelProQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddBill;
        private System.Windows.Forms.Button buttonPrintBill;
        private System.Windows.Forms.Button buttonDeleteProductFromCart;
        private System.Windows.Forms.DataGridView billDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProId;
        private System.Windows.Forms.Label labelProId;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.DataGridView orderDGV;
        public System.Windows.Forms.Label labelCartTotal;
        public System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.DataGridView productDGV;
    }
}
