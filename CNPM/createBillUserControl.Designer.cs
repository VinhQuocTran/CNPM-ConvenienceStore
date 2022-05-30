namespace WindowsFormsApp1
{
    partial class createBillUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createBillUserControl));
            this.labelProductName = new System.Windows.Forms.Label();
            this.productDGV = new System.Windows.Forms.DataGridView();
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
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Arial", 10F);
            this.labelProductName.Location = new System.Drawing.Point(16, 34);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(112, 19);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Tên sản phẩm";
            // 
            // productDGV
            // 
            this.productDGV.AllowUserToResizeColumns = false;
            this.productDGV.AllowUserToResizeRows = false;
            this.productDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.GridColor = System.Drawing.SystemColors.Control;
            this.productDGV.Location = new System.Drawing.Point(20, 321);
            this.productDGV.MultiSelect = false;
            this.productDGV.Name = "productDGV";
            this.productDGV.ReadOnly = true;
            this.productDGV.RowHeadersVisible = false;
            this.productDGV.RowHeadersWidth = 51;
            this.productDGV.RowTemplate.Height = 24;
            this.productDGV.Size = new System.Drawing.Size(278, 324);
            this.productDGV.TabIndex = 1;
            this.productDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDGV_CellClick);
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Arial", 10F);
            this.labelProductPrice.Location = new System.Drawing.Point(16, 119);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(66, 19);
            this.labelProductPrice.TabIndex = 3;
            this.labelProductPrice.Text = "Giá bán";
            // 
            // comboBoxSelectCategory
            // 
            this.comboBoxSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCategory.FormattingEnabled = true;
            this.comboBoxSelectCategory.Location = new System.Drawing.Point(20, 291);
            this.comboBoxSelectCategory.Name = "comboBoxSelectCategory";
            this.comboBoxSelectCategory.Size = new System.Drawing.Size(177, 24);
            this.comboBoxSelectCategory.TabIndex = 4;
            this.comboBoxSelectCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCategory_SelectedIndexChanged);
            this.comboBoxSelectCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSelectCategory_SelectionChangeCommitted);
            // 
            // labelProductUnit
            // 
            this.labelProductUnit.AutoSize = true;
            this.labelProductUnit.Font = new System.Drawing.Font("Arial", 10F);
            this.labelProductUnit.Location = new System.Drawing.Point(16, 77);
            this.labelProductUnit.Name = "labelProductUnit";
            this.labelProductUnit.Size = new System.Drawing.Size(89, 19);
            this.labelProductUnit.TabIndex = 5;
            this.labelProductUnit.Text = "Đơn vị tính";
            // 
            // labelProductEnterQuantity
            // 
            this.labelProductEnterQuantity.AutoSize = true;
            this.labelProductEnterQuantity.Font = new System.Drawing.Font("Arial", 10F);
            this.labelProductEnterQuantity.Location = new System.Drawing.Point(16, 205);
            this.labelProductEnterQuantity.Name = "labelProductEnterQuantity";
            this.labelProductEnterQuantity.Size = new System.Drawing.Size(117, 19);
            this.labelProductEnterQuantity.TabIndex = 6;
            this.labelProductEnterQuantity.Text = "Nhập số lượng";
            // 
            // labelProName
            // 
            this.labelProName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProName.Font = new System.Drawing.Font("Arial", 10F);
            this.labelProName.Location = new System.Drawing.Point(167, 28);
            this.labelProName.Name = "labelProName";
            this.labelProName.Size = new System.Drawing.Size(130, 25);
            this.labelProName.TabIndex = 8;
            this.labelProName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProUnit
            // 
            this.labelProUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProUnit.Font = new System.Drawing.Font("Arial", 10F);
            this.labelProUnit.Location = new System.Drawing.Point(167, 71);
            this.labelProUnit.Name = "labelProUnit";
            this.labelProUnit.Size = new System.Drawing.Size(130, 25);
            this.labelProUnit.TabIndex = 9;
            this.labelProUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProPrice
            // 
            this.labelProPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProPrice.Font = new System.Drawing.Font("Arial", 10F);
            this.labelProPrice.Location = new System.Drawing.Point(167, 113);
            this.labelProPrice.Name = "labelProPrice";
            this.labelProPrice.Size = new System.Drawing.Size(130, 25);
            this.labelProPrice.TabIndex = 10;
            this.labelProPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProQuantity
            // 
            this.textBoxProQuantity.Location = new System.Drawing.Point(167, 202);
            this.textBoxProQuantity.Name = "textBoxProQuantity";
            this.textBoxProQuantity.ShortcutsEnabled = false;
            this.textBoxProQuantity.Size = new System.Drawing.Size(130, 22);
            this.textBoxProQuantity.TabIndex = 11;
            this.textBoxProQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProQuantity_KeyPress);
            // 
            // labelProQuantity
            // 
            this.labelProQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProQuantity.Font = new System.Drawing.Font("Arial", 10F);
            this.labelProQuantity.Location = new System.Drawing.Point(167, 154);
            this.labelProQuantity.Name = "labelProQuantity";
            this.labelProQuantity.Size = new System.Drawing.Size(130, 25);
            this.labelProQuantity.TabIndex = 13;
            this.labelProQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hàng trong kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(326, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giỏ hàng";
            // 
            // orderDGV
            // 
            this.orderDGV.AllowUserToAddRows = false;
            this.orderDGV.AllowUserToResizeColumns = false;
            this.orderDGV.AllowUserToResizeRows = false;
            this.orderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.quantity,
            this.total,
            this.ProId});
            this.orderDGV.GridColor = System.Drawing.SystemColors.Control;
            this.orderDGV.Location = new System.Drawing.Point(330, 43);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.ReadOnly = true;
            this.orderDGV.RowHeadersVisible = false;
            this.orderDGV.RowHeadersWidth = 51;
            this.orderDGV.RowTemplate.Height = 24;
            this.orderDGV.Size = new System.Drawing.Size(455, 242);
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
            this.buttonAddProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.Location = new System.Drawing.Point(167, 239);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(131, 46);
            this.buttonAddProduct.TabIndex = 16;
            this.buttonAddProduct.Text = "Thêm vào giỏ";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(513, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng tiền:";
            // 
            // labelCartTotal
            // 
            this.labelCartTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCartTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.labelCartTotal.Location = new System.Drawing.Point(626, 291);
            this.labelCartTotal.Name = "labelCartTotal";
            this.labelCartTotal.Size = new System.Drawing.Size(159, 25);
            this.labelCartTotal.TabIndex = 18;
            this.labelCartTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddBill
            // 
            this.buttonAddBill.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBill.Location = new System.Drawing.Point(472, 590);
            this.buttonAddBill.Name = "buttonAddBill";
            this.buttonAddBill.Size = new System.Drawing.Size(131, 55);
            this.buttonAddBill.TabIndex = 19;
            this.buttonAddBill.Text = "Thanh toán";
            this.buttonAddBill.UseVisualStyleBackColor = true;
            this.buttonAddBill.Click += new System.EventHandler(this.buttonAddBill_Click);
            // 
            // buttonPrintBill
            // 
            this.buttonPrintBill.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintBill.Location = new System.Drawing.Point(654, 590);
            this.buttonPrintBill.Name = "buttonPrintBill";
            this.buttonPrintBill.Size = new System.Drawing.Size(131, 55);
            this.buttonPrintBill.TabIndex = 20;
            this.buttonPrintBill.Text = "In hoá đơn";
            this.buttonPrintBill.UseVisualStyleBackColor = true;
            this.buttonPrintBill.Click += new System.EventHandler(this.buttonPrintBill_Click);
            // 
            // buttonDeleteProductFromCart
            // 
            this.buttonDeleteProductFromCart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteProductFromCart.Location = new System.Drawing.Point(330, 291);
            this.buttonDeleteProductFromCart.Name = "buttonDeleteProductFromCart";
            this.buttonDeleteProductFromCart.Size = new System.Drawing.Size(157, 34);
            this.buttonDeleteProductFromCart.TabIndex = 21;
            this.buttonDeleteProductFromCart.Text = "Xoá khỏi giỏ";
            this.buttonDeleteProductFromCart.UseVisualStyleBackColor = true;
            this.buttonDeleteProductFromCart.Click += new System.EventHandler(this.buttonDeleteProductFromCart_Click);
            // 
            // billDGV
            // 
            this.billDGV.AllowUserToResizeColumns = false;
            this.billDGV.AllowUserToResizeRows = false;
            this.billDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.GridColor = System.Drawing.SystemColors.Control;
            this.billDGV.Location = new System.Drawing.Point(330, 377);
            this.billDGV.MultiSelect = false;
            this.billDGV.Name = "billDGV";
            this.billDGV.ReadOnly = true;
            this.billDGV.RowHeadersVisible = false;
            this.billDGV.RowHeadersWidth = 51;
            this.billDGV.RowTemplate.Height = 24;
            this.billDGV.Size = new System.Drawing.Size(455, 179);
            this.billDGV.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(326, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Hoá đơn bán trong ngày";
            // 
            // labelProId
            // 
            this.labelProId.AutoSize = true;
            this.labelProId.Location = new System.Drawing.Point(164, 11);
            this.labelProId.Name = "labelProId";
            this.labelProId.Size = new System.Drawing.Size(45, 17);
            this.labelProId.TabIndex = 24;
            this.labelProId.Text = "MãSP";
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // createBillUserControl
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
            this.Name = "createBillUserControl";
            this.Size = new System.Drawing.Size(797, 673);
            this.Load += new System.EventHandler(this.CreateBillControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.DataGridView productDGV;
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
        private System.Windows.Forms.Button buttonAddProduct;
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
    }
}
