using System;
using System.Windows.Forms;

namespace AddApplication.Src.AllForms
{
    public partial class FormMain : Form
    {
        private FormErrors _formErrors = null;
        private FormAppRequests _formAppRequests = null;
        private FormAppRemove _formAppRemove = null;
        private FormAppAdd _formAppAdd = null;

        private readonly FormHelper<FormMain> _formHelper;

        public FormMain()
        {
            Icon = Properties.Resources.logo21;

            InitializeComponent();

            _formHelper = new FormHelper<FormMain>(this);
        }

        private void CheckRequesting(object sender, EventArgs e)
        {
            bool isChecked = (sender as CheckBox).Checked;

            _formHelper.DisplayForm(isChecked, ref _formAppRequests);
        }

        private void CheckErrors(object sender, EventArgs e)
        {
            bool isChecked = (sender as CheckBox).Checked;

            _formHelper.DisplayForm(isChecked, ref _formErrors);
        }

        private void CheckRemoveApp(object sender, EventArgs e)
        {
            bool isChecked = (sender as CheckBox).Checked;

            _formHelper.DisplayForm(isChecked, ref _formAppRemove);
        }

        private void CheckAddApp(object sender, EventArgs e)
        {
            bool isChecked = (sender as CheckBox).Checked;

            _formHelper.DisplayForm(isChecked, ref _formAppAdd);
        }
    }
}