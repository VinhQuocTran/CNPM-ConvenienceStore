namespace WindowsFormsApp1
{
    partial class formAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAboutUs));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPictureComboBox = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.firstUC1 = new WindowsFormsApp1.FirstUC();
            this.iconPictureBoxClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonMember3 = new FontAwesome.Sharp.IconButton();
            this.iconButtonMember2 = new FontAwesome.Sharp.IconButton();
            this.iconButtonMember1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonLeader = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButtonMember3);
            this.panelMenu.Controls.Add(this.iconButtonMember2);
            this.panelMenu.Controls.Add(this.iconButtonMember1);
            this.panelMenu.Controls.Add(this.iconButtonLeader);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 384);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.iconPictureBoxClose);
            this.panel1.Controls.Add(this.labelPictureComboBox);
            this.panel1.Controls.Add(this.iconPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 61);
            this.panel1.TabIndex = 1;
            // 
            // labelPictureComboBox
            // 
            this.labelPictureComboBox.AutoSize = true;
            this.labelPictureComboBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPictureComboBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPictureComboBox.Location = new System.Drawing.Point(27, 42);
            this.labelPictureComboBox.Name = "labelPictureComboBox";
            this.labelPictureComboBox.Size = new System.Drawing.Size(51, 19);
            this.labelPictureComboBox.TabIndex = 1;
            this.labelPictureComboBox.Text = "Home";
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.firstUC1);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfile.Location = new System.Drawing.Point(220, 61);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(844, 323);
            this.panelProfile.TabIndex = 2;
            // 
            // firstUC1
            // 
            this.firstUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstUC1.BackgroundImage")));
            this.firstUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstUC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.firstUC1.Location = new System.Drawing.Point(0, 0);
            this.firstUC1.Name = "firstUC1";
            this.firstUC1.Size = new System.Drawing.Size(844, 323);
            this.firstUC1.TabIndex = 0;
            this.firstUC1.Visible = false;
            // 
            // iconPictureBoxClose
            // 
            this.iconPictureBoxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBoxClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.iconPictureBoxClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBoxClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.iconPictureBoxClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxClose.IconSize = 48;
            this.iconPictureBoxClose.Location = new System.Drawing.Point(793, 0);
            this.iconPictureBoxClose.Name = "iconPictureBoxClose";
            this.iconPictureBoxClose.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBoxClose.TabIndex = 2;
            this.iconPictureBoxClose.TabStop = false;
            this.iconPictureBoxClose.Click += new System.EventHandler(this.iconPictureBoxClose_Click);
            this.iconPictureBoxClose.MouseEnter += new System.EventHandler(this.iconPictureBoxClose_MouseEnter);
            this.iconPictureBoxClose.MouseLeave += new System.EventHandler(this.iconPictureBoxClose_MouseLeave);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox.ForeColor = System.Drawing.Color.Magenta;
            this.iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox.IconColor = System.Drawing.Color.Magenta;
            this.iconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox.Location = new System.Drawing.Point(0, 29);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            // 
            // iconButtonMember3
            // 
            this.iconButtonMember3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMember3.FlatAppearance.BorderSize = 0;
            this.iconButtonMember3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMember3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMember3.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonMember3.IconChar = FontAwesome.Sharp.IconChar.Dove;
            this.iconButtonMember3.IconColor = System.Drawing.Color.White;
            this.iconButtonMember3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMember3.IconSize = 32;
            this.iconButtonMember3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMember3.Location = new System.Drawing.Point(0, 320);
            this.iconButtonMember3.Name = "iconButtonMember3";
            this.iconButtonMember3.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.iconButtonMember3.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMember3.TabIndex = 4;
            this.iconButtonMember3.Text = "Thành viên";
            this.iconButtonMember3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMember3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMember3.UseVisualStyleBackColor = true;
            this.iconButtonMember3.Click += new System.EventHandler(this.iconButtonMember3_Click);
            // 
            // iconButtonMember2
            // 
            this.iconButtonMember2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMember2.FlatAppearance.BorderSize = 0;
            this.iconButtonMember2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMember2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMember2.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonMember2.IconChar = FontAwesome.Sharp.IconChar.Crow;
            this.iconButtonMember2.IconColor = System.Drawing.Color.White;
            this.iconButtonMember2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMember2.IconSize = 32;
            this.iconButtonMember2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMember2.Location = new System.Drawing.Point(0, 260);
            this.iconButtonMember2.Name = "iconButtonMember2";
            this.iconButtonMember2.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.iconButtonMember2.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMember2.TabIndex = 3;
            this.iconButtonMember2.Text = "Thành viên";
            this.iconButtonMember2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMember2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMember2.UseVisualStyleBackColor = true;
            this.iconButtonMember2.Click += new System.EventHandler(this.iconButtonMember2_Click);
            // 
            // iconButtonMember1
            // 
            this.iconButtonMember1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMember1.FlatAppearance.BorderSize = 0;
            this.iconButtonMember1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMember1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMember1.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonMember1.IconChar = FontAwesome.Sharp.IconChar.KiwiBird;
            this.iconButtonMember1.IconColor = System.Drawing.Color.White;
            this.iconButtonMember1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMember1.IconSize = 32;
            this.iconButtonMember1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMember1.Location = new System.Drawing.Point(0, 200);
            this.iconButtonMember1.Name = "iconButtonMember1";
            this.iconButtonMember1.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.iconButtonMember1.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMember1.TabIndex = 2;
            this.iconButtonMember1.Text = "Thành viên";
            this.iconButtonMember1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMember1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMember1.UseVisualStyleBackColor = true;
            this.iconButtonMember1.Click += new System.EventHandler(this.iconButtonMember1_Click);
            // 
            // iconButtonLeader
            // 
            this.iconButtonLeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonLeader.FlatAppearance.BorderSize = 0;
            this.iconButtonLeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLeader.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonLeader.IconChar = FontAwesome.Sharp.IconChar.Earlybirds;
            this.iconButtonLeader.IconColor = System.Drawing.Color.White;
            this.iconButtonLeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLeader.IconSize = 32;
            this.iconButtonLeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLeader.Location = new System.Drawing.Point(0, 140);
            this.iconButtonLeader.Name = "iconButtonLeader";
            this.iconButtonLeader.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.iconButtonLeader.Size = new System.Drawing.Size(220, 60);
            this.iconButtonLeader.TabIndex = 1;
            this.iconButtonLeader.Text = "Trưởng nhóm";
            this.iconButtonLeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLeader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLeader.UseVisualStyleBackColor = true;
            this.iconButtonLeader.Click += new System.EventHandler(this.iconButtonLeader_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(209, 123);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // formAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 384);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "formAboutUs";
            this.Text = "formAboutUs";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonLeader;
        private FontAwesome.Sharp.IconButton iconButtonMember3;
        private FontAwesome.Sharp.IconButton iconButtonMember2;
        private FontAwesome.Sharp.IconButton iconButtonMember1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox;
        private System.Windows.Forms.Label labelPictureComboBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxClose;
        private System.Windows.Forms.Panel panelProfile;
        private FirstUC firstUC1;
    }
}