using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddApplication.Src.AllForms
{
    partial class FormPhone
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
            this.components = new System.ComponentModel.Container();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.picPegi = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstImages = new System.Windows.Forms.ListView();
            this.lblDownloads = new System.Windows.Forms.Label();
            this.lblReviewStar = new System.Windows.Forms.Label();
            this.lblReviewTotal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPegi)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.Location = new System.Drawing.Point(35, 84);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(57, 53);
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;
            // 
            // picPegi
            // 
            this.picPegi.Location = new System.Drawing.Point(252, 172);
            this.picPegi.Name = "picPegi";
            this.picPegi.Size = new System.Drawing.Size(24, 24);
            this.picPegi.TabIndex = 3;
            this.picPegi.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstImages
            // 
            this.lstImages.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstImages.HideSelection = false;
            this.lstImages.Location = new System.Drawing.Point(0, 275);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(316, 194);
            this.lstImages.TabIndex = 4;
            this.lstImages.UseCompatibleStateImageBehavior = false;
            // 
            // lblDownloads
            // 
            this.lblDownloads.AutoSize = true;
            this.lblDownloads.Location = new System.Drawing.Point(149, 177);
            this.lblDownloads.Name = "lblDownloads";
            this.lblDownloads.Size = new System.Drawing.Size(16, 15);
            this.lblDownloads.TabIndex = 5;
            this.lblDownloads.Text = "...";
            // 
            // lblReviewStar
            // 
            this.lblReviewStar.AutoSize = true;
            this.lblReviewStar.Location = new System.Drawing.Point(35, 181);
            this.lblReviewStar.Name = "lblReviewStar";
            this.lblReviewStar.Size = new System.Drawing.Size(16, 15);
            this.lblReviewStar.TabIndex = 5;
            this.lblReviewStar.Text = "...";
            // 
            // lblReviewTotal
            // 
            this.lblReviewTotal.AutoSize = true;
            this.lblReviewTotal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblReviewTotal.Location = new System.Drawing.Point(22, 202);
            this.lblReviewTotal.Name = "lblReviewTotal";
            this.lblReviewTotal.Size = new System.Drawing.Size(61, 15);
            this.lblReviewTotal.TabIndex = 5;
            this.lblReviewTotal.Text = "... Reviews";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(110, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 75);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "...";
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAbout.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAbout.Location = new System.Drawing.Point(12, 503);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(293, 80);
            this.lblAbout.TabIndex = 5;
            this.lblAbout.Text = "...";
            // 
            // FormPhone
            // 
            this.ClientSize = new System.Drawing.Size(317, 654);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblReviewTotal);
            this.Controls.Add(this.lblReviewStar);
            this.Controls.Add(this.lblDownloads);
            this.Controls.Add(this.lstImages);
            this.Controls.Add(this.picPegi);
            this.Controls.Add(this.picIcon);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(333, 693);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(333, 693);
            this.Name = "FormPhone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPegi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        public PictureBox picIcon;
        private PictureBox picPegi;
        private ImageList imageList1;
        private ListView lstImages;
        private Label lblDownloads;
        private Label lblReviewStar;
        private Label lblReviewTotal;
        private Label lblTitle;
        private Label lblAbout;
    }
}
