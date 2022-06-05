namespace WindowsFormsApp1
{
    partial class ThirdUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThirdUC));
            this.iconPictureBoxFB = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxGithub = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBoxFB
            // 
            this.iconPictureBoxFB.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxFB.ForeColor = System.Drawing.Color.Blue;
            this.iconPictureBoxFB.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.iconPictureBoxFB.IconColor = System.Drawing.Color.Blue;
            this.iconPictureBoxFB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxFB.Location = new System.Drawing.Point(220, 207);
            this.iconPictureBoxFB.Name = "iconPictureBoxFB";
            this.iconPictureBoxFB.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxFB.TabIndex = 11;
            this.iconPictureBoxFB.TabStop = false;
            this.iconPictureBoxFB.Click += new System.EventHandler(this.iconPictureBoxFB_Click);
            // 
            // iconPictureBoxGithub
            // 
            this.iconPictureBoxGithub.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxGithub.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBoxGithub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.iconPictureBoxGithub.IconColor = System.Drawing.Color.Black;
            this.iconPictureBoxGithub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxGithub.Location = new System.Drawing.Point(162, 207);
            this.iconPictureBoxGithub.Name = "iconPictureBoxGithub";
            this.iconPictureBoxGithub.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxGithub.TabIndex = 10;
            this.iconPictureBoxGithub.TabStop = false;
            this.iconPictureBoxGithub.Click += new System.EventHandler(this.iconPictureBoxGithub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(107, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "MSSV: 52000815";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(107, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trần Minh Trí";
            // 
            // ThirdUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.iconPictureBoxFB);
            this.Controls.Add(this.iconPictureBoxGithub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThirdUC";
            this.Size = new System.Drawing.Size(844, 323);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFB;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxGithub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
