namespace WindowsFormsApp1
{
    partial class formProgess
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.customBtnAbout = new WindowsFormsApp1.CustomButton();
            this.customBtnExit = new WindowsFormsApp1.CustomButton();
            this.customBtnEnter = new WindowsFormsApp1.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ CỬA HÀNG TIỆN LỢI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(165, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "( Phiên bản 2.0 )";
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 500;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(149)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(147, 116);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar.ProgressWidth = 10;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.Size = new System.Drawing.Size(132, 128);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "";
            this.circularProgressBar.TabIndex = 6;
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(165, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "© CNPM nhóm 2";
            // 
            // customBtnAbout
            // 
            this.customBtnAbout.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.customBtnAbout.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.customBtnAbout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customBtnAbout.BorderRadius = 40;
            this.customBtnAbout.BorderSize = 0;
            this.customBtnAbout.FlatAppearance.BorderSize = 0;
            this.customBtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtnAbout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBtnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.customBtnAbout.Location = new System.Drawing.Point(168, 219);
            this.customBtnAbout.Name = "customBtnAbout";
            this.customBtnAbout.Size = new System.Drawing.Size(96, 40);
            this.customBtnAbout.TabIndex = 10;
            this.customBtnAbout.Text = "About us";
            this.customBtnAbout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.customBtnAbout.UseVisualStyleBackColor = false;
            this.customBtnAbout.Click += new System.EventHandler(this.customBtnAbout_Click);
            // 
            // customBtnExit
            // 
            this.customBtnExit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.customBtnExit.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.customBtnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customBtnExit.BorderRadius = 40;
            this.customBtnExit.BorderSize = 0;
            this.customBtnExit.FlatAppearance.BorderSize = 0;
            this.customBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.customBtnExit.Location = new System.Drawing.Point(168, 164);
            this.customBtnExit.Name = "customBtnExit";
            this.customBtnExit.Size = new System.Drawing.Size(96, 39);
            this.customBtnExit.TabIndex = 9;
            this.customBtnExit.Text = "Thoát ra";
            this.customBtnExit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.customBtnExit.UseVisualStyleBackColor = false;
            this.customBtnExit.Click += new System.EventHandler(this.customBtnExit_Click);
            // 
            // customBtnEnter
            // 
            this.customBtnEnter.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.customBtnEnter.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.customBtnEnter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customBtnEnter.BorderRadius = 40;
            this.customBtnEnter.BorderSize = 0;
            this.customBtnEnter.FlatAppearance.BorderSize = 0;
            this.customBtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtnEnter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBtnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.customBtnEnter.Location = new System.Drawing.Point(168, 105);
            this.customBtnEnter.Name = "customBtnEnter";
            this.customBtnEnter.Size = new System.Drawing.Size(96, 40);
            this.customBtnEnter.TabIndex = 8;
            this.customBtnEnter.Text = "Vào";
            this.customBtnEnter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(131)))));
            this.customBtnEnter.UseVisualStyleBackColor = false;
            this.customBtnEnter.Click += new System.EventHandler(this.customBtnEnter_Click);
            // 
            // formProgess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(434, 297);
            this.Controls.Add(this.customBtnAbout);
            this.Controls.Add(this.customBtnExit);
            this.Controls.Add(this.customBtnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.circularProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "formProgess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProgess";
            this.Load += new System.EventHandler(this.formProgess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Label label2;
        private CustomButton customBtnEnter;
        private CustomButton customBtnExit;
        private CustomButton customBtnAbout;
    }
}