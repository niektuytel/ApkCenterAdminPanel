using System;
using System.Collections.Generic;
using System.Text;

namespace AddApplication.Src.AllForms
{
    public partial class FormAppRemove
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(452, 39);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 28);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.UpdateRemoveApp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.MaximumSize = new System.Drawing.Size(57, 15);
            this.label1.MinimumSize = new System.Drawing.Size(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "App Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(73, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(473, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(13, 46);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(63, 15);
            this.lblResponse.TabIndex = 3;
            this.lblResponse.Text = "Response: ";
            // 
            // FormAppRemove
            // 
            this.ClientSize = new System.Drawing.Size(549, 71);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAppRemove";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblResponse;
    }
}
