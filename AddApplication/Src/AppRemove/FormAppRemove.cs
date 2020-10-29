using AddApplication.Src.Http.Api;
using AddApplication.Utils;
using System;
using System.Windows.Forms;

namespace AddApplication.Src.AllForms
{

    public partial class FormAppRemove : Form
    {
        //private readonly

        private readonly FormMain _formMain;
        private readonly ApiApp _apiApp;

        public FormAppRemove(FormMain formMain)
        {
            Icon = Properties.Resources.logo21;

            _formMain = formMain;
            _apiApp = new ApiApp();

            InitializeComponent();
        }

        private void UpdateFormClosing(object sender, FormClosingEventArgs e)
        {
            _formMain.cbFormRemoveApp.Checked = false;
        }

        private void UpdateRemoveApp(object sender, EventArgs e)
        {
            lblResponse.Text = "Response: Loading...";

            string title = Create.AsUrlEnCoded(txtTitle.Text);
            bool succeedded = _apiApp.Delete(title);

            if (succeedded)
            {
                lblResponse.Text = "Response: The requested title founded on the server and been deleted successfully";
            } else {
                lblResponse.Text = "Response: " + txtTitle.Text + " Failed, not founded on the server";
            }
        }

    }
}
