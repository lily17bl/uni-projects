﻿using Eyes.Properties;

namespace Eyes
{
    partial class EyesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            eyesImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)eyesImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // eyesImage
            // 
            eyesImage.Image = Resources.eyes_Center;
            eyesImage.Location = new Point(265, 70);
            eyesImage.Name = "eyesImage";
            eyesImage.Size = new Size(240, 378);
            eyesImage.SizeMode = PictureBoxSizeMode.Zoom;
            eyesImage.TabIndex = 0;
            eyesImage.TabStop = false;
            eyesImage.MouseDown += eyesImage_MouseDown;
            eyesImage.MouseMove += eyesImage_MouseMove;
            eyesImage.MouseUp += eyesImage_MouseUp;
            // 
            // EyesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 216, 219);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(eyesImage);
            Name = "EyesForm";
            Text = "Eyes";
            Load += EyesForm_Load;
            MouseMove += EyesForm_MouseMove;
            Resize += EyesForm_Resize;
            ((System.ComponentModel.ISupportInitialize)eyesImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox eyesImage;
    }
}
