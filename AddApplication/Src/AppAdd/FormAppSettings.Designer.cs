using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AddApplication.Src.AllForms
{
    public partial class FormAppSettings
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
        /// 
        private void InitializeComponent()
        {
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.btnCategoryRemove = new System.Windows.Forms.Button();
            this.text_images_height = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstApis = new System.Windows.Forms.ListBox();
            this.txtApiName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApiPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApiRemove = new System.Windows.Forms.Button();
            this.btnApiAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNederland = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGlobally = new System.Windows.Forms.TextBox();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(409, 242);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(116, 23);
            this.btnCategoryAdd.TabIndex = 2;
            this.btnCategoryAdd.Text = "add";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.Categories_ButtonClicked);
            // 
            // btnCategoryRemove
            // 
            this.btnCategoryRemove.Location = new System.Drawing.Point(284, 242);
            this.btnCategoryRemove.Name = "btnCategoryRemove";
            this.btnCategoryRemove.Size = new System.Drawing.Size(119, 23);
            this.btnCategoryRemove.TabIndex = 2;
            this.btnCategoryRemove.Text = "remove";
            this.btnCategoryRemove.UseVisualStyleBackColor = true;
            this.btnCategoryRemove.Click += new System.EventHandler(this.Categories_ButtonClicked);
            // 
            // text_images_height
            // 
            this.text_images_height.Location = new System.Drawing.Point(0, 0);
            this.text_images_height.Name = "text_images_height";
            this.text_images_height.Size = new System.Drawing.Size(100, 23);
            this.text_images_height.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(0, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstApis);
            this.groupBox2.Controls.Add(this.txtApiName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtApiPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnApiRemove);
            this.groupBox2.Controls.Add(this.btnApiAdd);
            this.groupBox2.Location = new System.Drawing.Point(554, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Api Types";
            // 
            // lstApis
            // 
            this.lstApis.FormattingEnabled = true;
            this.lstApis.ItemHeight = 15;
            this.lstApis.Location = new System.Drawing.Point(15, 23);
            this.lstApis.Name = "lstApis";
            this.lstApis.Size = new System.Drawing.Size(245, 124);
            this.lstApis.TabIndex = 3;
            this.lstApis.SelectedIndexChanged += new System.EventHandler(this.ApiTypes_Selected);
            // 
            // txtApiName
            // 
            this.txtApiName.Location = new System.Drawing.Point(142, 184);
            this.txtApiName.Name = "txtApiName";
            this.txtApiName.Size = new System.Drawing.Size(118, 23);
            this.txtApiName.TabIndex = 4;
            this.txtApiName.TextChanged += new System.EventHandler(this.ApiTypes_EditText);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Api Name: ";
            // 
            // txtApiPath
            // 
            this.txtApiPath.Location = new System.Drawing.Point(142, 210);
            this.txtApiPath.Name = "txtApiPath";
            this.txtApiPath.Size = new System.Drawing.Size(118, 23);
            this.txtApiPath.TabIndex = 4;
            this.txtApiPath.TextChanged += new System.EventHandler(this.ApiTypes_EditText);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "http://ServerAddress/";
            // 
            // btnApiRemove
            // 
            this.btnApiRemove.Location = new System.Drawing.Point(17, 240);
            this.btnApiRemove.Name = "btnApiRemove";
            this.btnApiRemove.Size = new System.Drawing.Size(119, 23);
            this.btnApiRemove.TabIndex = 2;
            this.btnApiRemove.Text = "remove";
            this.btnApiRemove.UseVisualStyleBackColor = true;
            this.btnApiRemove.Click += new System.EventHandler(this.ApiTypes_ButtonClicked);
            // 
            // btnApiAdd
            // 
            this.btnApiAdd.Location = new System.Drawing.Point(142, 240);
            this.btnApiAdd.Name = "btnApiAdd";
            this.btnApiAdd.Size = new System.Drawing.Size(116, 23);
            this.btnApiAdd.TabIndex = 2;
            this.btnApiAdd.Text = "add";
            this.btnApiAdd.UseVisualStyleBackColor = true;
            this.btnApiAdd.Click += new System.EventHandler(this.ApiTypes_ButtonClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Globally:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNederland);
            this.groupBox3.Controls.Add(this.btnCategoryAdd);
            this.groupBox3.Controls.Add(this.btnCategoryRemove);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtGlobally);
            this.groupBox3.Controls.Add(this.lstCategories);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(7, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 284);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categories";
            // 
            // txtNederland
            // 
            this.txtNederland.Location = new System.Drawing.Point(82, 49);
            this.txtNederland.Name = "txtNederland";
            this.txtNederland.Size = new System.Drawing.Size(196, 23);
            this.txtNederland.TabIndex = 1;
            this.txtNederland.TextChanged += new System.EventHandler(this.Categories_EditText);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nederland:";
            // 
            // txtGlobally
            // 
            this.txtGlobally.Location = new System.Drawing.Point(82, 22);
            this.txtGlobally.Name = "txtGlobally";
            this.txtGlobally.Size = new System.Drawing.Size(196, 23);
            this.txtGlobally.TabIndex = 1;
            this.txtGlobally.TextChanged += new System.EventHandler(this.Categories_EditText);
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 15;
            this.lstCategories.Location = new System.Drawing.Point(284, 22);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(241, 214);
            this.lstCategories.TabIndex = 3;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.Categories_Selected);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FormAppSettings
            // 
            this.ClientSize = new System.Drawing.Size(835, 296);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(851, 335);
            this.MinimumSize = new System.Drawing.Size(851, 335);
            this.Name = "FormAppSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCategoryAdd;
        private Button btnCategoryRemove;
        private TextBox text_images_height;
        private TextBox textBox7;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private TextBox txtApiName;
        private Label label3;
        private TextBox txtApiPath;
        private Label label2;
        private Label label1;
        private ListBox lstApis;
        private Button btnApiAdd;
        private Button btnApiRemove;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txtNederland;
        private Label label5;
        private TextBox txtGlobally;
        private ListBox lstCategories;
        private PrintDialog printDialog1;
    }
}
