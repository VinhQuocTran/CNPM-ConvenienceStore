namespace WindowsFormsApp1
{
    partial class FirstUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstUC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBoxGithub = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxFB = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(529, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trần Quốc Vinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(529, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV: 52000815";
            // 
            // iconPictureBoxGithub
            // 
            this.iconPictureBoxGithub.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxGithub.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBoxGithub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.iconPictureBoxGithub.IconColor = System.Drawing.Color.Black;
            this.iconPictureBoxGithub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxGithub.Location = new System.Drawing.Point(584, 213);
            this.iconPictureBoxGithub.Name = "iconPictureBoxGithub";
            this.iconPictureBoxGithub.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxGithub.TabIndex = 2;
            this.iconPictureBoxGithub.TabStop = false;
            this.iconPictureBoxGithub.Click += new System.EventHandler(this.iconPictureBoxGithub_Click);
            // 
            // iconPictureBoxFB
            // 
            this.iconPictureBoxFB.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxFB.ForeColor = System.Drawing.Color.Blue;
            this.iconPictureBoxFB.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.iconPictureBoxFB.IconColor = System.Drawing.Color.Blue;
            this.iconPictureBoxFB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxFB.Location = new System.Drawing.Point(642, 213);
            this.iconPictureBoxFB.Name = "iconPictureBoxFB";
            this.iconPictureBoxFB.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxFB.TabIndex = 3;
            this.iconPictureBoxFB.TabStop = false;
            this.iconPictureBoxFB.Click += new System.EventHandler(this.iconPictureBoxFB_Click);
            // 
            // FirstUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.iconPictureBoxFB);
            this.Controls.Add(this.iconPictureBoxGithub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.Name = "FirstUC";
            this.Size = new System.Drawing.Size(844, 323);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxGithub;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFB;
    }
}
