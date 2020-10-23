using AddApplication.Utils;
using System;
using System.Web;
using System.Windows.Forms;

namespace AddApplication.Src.AllForms
{

    public partial class FormAppRemove : Form
    {
        private readonly FormMain _formMain;
        private readonly HttpApi _httpApi;

        public FormAppRemove(FormMain formMain)
        {
            Icon = Properties.Resources.logo21;

            InitializeComponent();

            _formMain = formMain;
            _httpApi = new HttpApi();
        }

        private void UpdateFormClosing(object sender, FormClosingEventArgs e)
        {
            _formMain.cbFormRemoveApp.Checked = false;
        }

        private void UpdateRemoveApp(object sender, EventArgs e)
        {
            string title = Create.AsUrlEnCoded(txtTitle.Text);

            lblResponse.Text = "Response: Loading...";

            if(_httpApi.IsApiRemovingApp(title))
            {
                lblResponse.Text = "Response: The requested title founded on the server and been deleted successfully";
            } else {
                lblResponse.Text = "Response: " + txtTitle.Text + " Failed, not founded on the server";
            }
        }

    }
}
