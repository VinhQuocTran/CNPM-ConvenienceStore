﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WindowsFormsApp1
{
    public partial class FormAboutUs : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;


        // Constructor
        public FormAboutUs()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            // Form
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        // Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Change iconPictureBox
                iconPictureBox.IconChar = currentBtn.IconChar;
                iconPictureBox.IconColor = currentBtn.IconColor;
                labelPictureComboBox.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void iconButtonLeader_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            bunifuTransition2.HideSync(defaultUC1);
            bunifuTransition2.HideSync(secondUC1);
            bunifuTransition2.HideSync(thirdUC1);
            bunifuTransition2.HideSync(fourthUC1);

            bunifuTransition1.ShowSync(firstUC1);
        }

        private void iconButtonMember1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            bunifuTransition2.HideSync(defaultUC1);
            bunifuTransition2.HideSync(firstUC1);
            bunifuTransition2.HideSync(thirdUC1);
            bunifuTransition2.HideSync(fourthUC1);

            bunifuTransition1.ShowSync(secondUC1);

        }

        private void iconButtonMember2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);

            bunifuTransition2.HideSync(defaultUC1);
            bunifuTransition2.HideSync(firstUC1);
            bunifuTransition2.HideSync(secondUC1);
            bunifuTransition2.HideSync(fourthUC1);

            bunifuTransition1.ShowSync(thirdUC1);

        }

        private void iconButtonMember3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            bunifuTransition2.HideSync(defaultUC1);
            bunifuTransition2.HideSync(firstUC1);
            bunifuTransition2.HideSync(secondUC1);
            bunifuTransition2.HideSync(thirdUC1);

            bunifuTransition1.ShowSync(fourthUC1);

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Reset();
            bunifuTransition2.HideSync(firstUC1);
            bunifuTransition2.HideSync(secondUC1);
            bunifuTransition2.HideSync(thirdUC1);
            bunifuTransition2.HideSync(fourthUC1);

            bunifuTransition1.ShowSync(defaultUC1);
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPictureBox.IconChar = IconChar.Home;
            iconPictureBox.IconColor = Color.Gainsboro;
            labelPictureComboBox.Text = "Home";
        }

        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProgess formProgress = new FormProgess();
            formProgress.Show();
        }

        private void iconPictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBoxClose.IconColor = Color.Red;
            Cursor.Current = Cursors.Hand;
        }

        private void iconPictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBoxClose.IconColor = Color.FromArgb(255, 209, 84);
            Cursor.Current = Cursors.Default;
        }
    }
}
