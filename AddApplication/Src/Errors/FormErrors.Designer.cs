using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AddApplication.Src.AllForms
{
    public partial class FormErrors
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
            this.cboxErrorType = new System.Windows.Forms.ComboBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimesError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxErrorType
            // 
            this.cboxErrorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxErrorType.FormattingEnabled = true;
            this.cboxErrorType.Location = new System.Drawing.Point(657, 3);
            this.cboxErrorType.Name = "cboxErrorType";
            this.cboxErrorType.Size = new System.Drawing.Size(158, 23);
            this.cboxErrorType.TabIndex = 0;
            this.cboxErrorType.SelectedIndexChanged += new System.EventHandler(this.UpdateErrorType);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(3, 47);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtError.ShortcutsEnabled = false;
            this.txtError.Size = new System.Drawing.Size(812, 689);
            this.txtError.TabIndex = 2;
            this.txtError.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(358, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 38);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "catched error";
            // 
            // lblTimesError
            // 
            this.lblTimesError.AutoSize = true;
            this.lblTimesError.Location = new System.Drawing.Point(742, 29);
            this.lblTimesError.Name = "lblTimesError";
            this.lblTimesError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimesError.Size = new System.Drawing.Size(13, 15);
            this.lblTimesError.TabIndex = 5;
            this.lblTimesError.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "times";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(455, 3);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 38);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(317, 3);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 38);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // FormErrors
            // 
            this.ClientSize = new System.Drawing.Size(818, 739);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTimesError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.cboxErrorType);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(834, 778);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(834, 778);
            this.Name = "FormErrors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboxErrorType;
        private TextBox txtError;
        private Button btnRemove;
        private Label label2;
        private Label lblTimesError;
        private Label label4;
        private Button btnNext;
        private Button btnPrevious;
    }
}
