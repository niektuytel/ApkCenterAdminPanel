using System.Windows.Forms;

namespace AddApplication.Src.AllForms
{
    public partial class FormAppRequests
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRequestedTimes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.list_suggestions = new System.Windows.Forms.ListBox();
            this.lblRequestedTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(373, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 38);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(470, 3);
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
            this.btnPrevious.Location = new System.Drawing.Point(332, 3);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 38);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "requested Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "requested";
            // 
            // lblRequestedTimes
            // 
            this.lblRequestedTimes.AutoSize = true;
            this.lblRequestedTimes.Location = new System.Drawing.Point(706, 15);
            this.lblRequestedTimes.Name = "lblRequestedTimes";
            this.lblRequestedTimes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRequestedTimes.Size = new System.Drawing.Size(13, 15);
            this.lblRequestedTimes.TabIndex = 5;
            this.lblRequestedTimes.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "times";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(699, 314);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 19);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "auto update";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(632, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "update main window";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // list_suggestions
            // 
            this.list_suggestions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.list_suggestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_suggestions.FormattingEnabled = true;
            this.list_suggestions.ItemHeight = 15;
            this.list_suggestions.Location = new System.Drawing.Point(5, 55);
            this.list_suggestions.Name = "list_suggestions";
            this.list_suggestions.Size = new System.Drawing.Size(320, 302);
            this.list_suggestions.TabIndex = 8;
            this.list_suggestions.Visible = false;
            // 
            // lblRequestedTitle
            // 
            this.lblRequestedTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRequestedTitle.Location = new System.Drawing.Point(118, 15);
            this.lblRequestedTitle.Name = "lblRequestedTitle";
            this.lblRequestedTitle.ReadOnly = true;
            this.lblRequestedTitle.Size = new System.Drawing.Size(163, 16);
            this.lblRequestedTitle.TabIndex = 9;
            this.lblRequestedTitle.Text = "?";
            // 
            // FormAppRequests
            // 
            this.ClientSize = new System.Drawing.Size(791, 52);
            this.Controls.Add(this.lblRequestedTitle);
            this.Controls.Add(this.list_suggestions);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRequestedTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRemove);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(807, 91);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(807, 91);
            this.Name = "FormAppRequests";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnRemove;
        private Button btnNext;
        private Button btnPrevious;
        private Label label1;
        private Label label3;
        private Label lblRequestedTimes;
        private Label label5;
        private RadioButton radioButton1;
        private Button button5;
        private ListBox list_suggestions;
        private TextBox lblRequestedTitle;
    }
}
