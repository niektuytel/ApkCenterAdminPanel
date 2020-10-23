
namespace AddApplication.Src.AllForms
{
    public partial class FormMain
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
            this.cbFormRemoveApp = new System.Windows.Forms.CheckBox();
            this.cbFormRequesting = new System.Windows.Forms.CheckBox();
            this.cbFormErrors = new System.Windows.Forms.CheckBox();
            this.cbFormAddApp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbFormRemoveApp
            // 
            this.cbFormRemoveApp.AutoSize = true;
            this.cbFormRemoveApp.Location = new System.Drawing.Point(12, 37);
            this.cbFormRemoveApp.Name = "cbFormRemoveApp";
            this.cbFormRemoveApp.Size = new System.Drawing.Size(133, 19);
            this.cbFormRemoveApp.TabIndex = 13;
            this.cbFormRemoveApp.Text = "Application Remove";
            this.cbFormRemoveApp.UseVisualStyleBackColor = true;
            this.cbFormRemoveApp.CheckedChanged += new System.EventHandler(this.CheckRemoveApp);
            // 
            // cbFormRequesting
            // 
            this.cbFormRequesting.AutoSize = true;
            this.cbFormRequesting.Location = new System.Drawing.Point(12, 12);
            this.cbFormRequesting.Name = "cbFormRequesting";
            this.cbFormRequesting.Size = new System.Drawing.Size(137, 19);
            this.cbFormRequesting.TabIndex = 13;
            this.cbFormRequesting.Text = "Application Requests";
            this.cbFormRequesting.UseVisualStyleBackColor = true;
            this.cbFormRequesting.CheckedChanged += new System.EventHandler(this.CheckRequesting);
            // 
            // cbFormErrors
            // 
            this.cbFormErrors.AutoSize = true;
            this.cbFormErrors.Location = new System.Drawing.Point(12, 86);
            this.cbFormErrors.Name = "cbFormErrors";
            this.cbFormErrors.Size = new System.Drawing.Size(56, 19);
            this.cbFormErrors.TabIndex = 13;
            this.cbFormErrors.Text = "Errors";
            this.cbFormErrors.UseVisualStyleBackColor = true;
            this.cbFormErrors.CheckedChanged += new System.EventHandler(this.CheckErrors);
            // 
            // cbFormAddApp
            // 
            this.cbFormAddApp.AutoSize = true;
            this.cbFormAddApp.Location = new System.Drawing.Point(12, 62);
            this.cbFormAddApp.Name = "cbFormAddApp";
            this.cbFormAddApp.Size = new System.Drawing.Size(112, 19);
            this.cbFormAddApp.TabIndex = 13;
            this.cbFormAddApp.Text = "Application Add";
            this.cbFormAddApp.UseVisualStyleBackColor = true;
            this.cbFormAddApp.CheckedChanged += new System.EventHandler(this.CheckAddApp);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.cbFormAddApp);
            this.Controls.Add(this.cbFormErrors);
            this.Controls.Add(this.cbFormRequesting);
            this.Controls.Add(this.cbFormRemoveApp);
            this.MaximumSize = new System.Drawing.Size(250, 150);
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cbFormRemoveApp;
        public System.Windows.Forms.CheckBox cbFormRequesting;
        public System.Windows.Forms.CheckBox cbFormErrors;
        public System.Windows.Forms.CheckBox cbFormAddApp;
    }
}
