using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AddApplication.Models;
using AddApplication.Src.FormRequests;
using AddApplication.Utils;

namespace AddApplication.Src.AllForms
{
    public partial class FormAppRequests: Form
    {
        private readonly FormMain _formMain;
        private readonly EditString _editString;
        private readonly HttpApi _httpApi;
        private readonly List<AppRequestModel> _requests;

        private int _requestIndex = 0;

        public FormAppRequests(FormMain formMain)
        {
            this.Icon = Properties.Resources.logo21;

            InitializeComponent();

            _formMain = formMain;
            _editString = new EditString();
            _httpApi = new HttpApi();
            _requests = _httpApi.ApiGetRequests();

            DisplayTxts();
            DisplayButtons();
        }


        private void UpdateFormClosing(object sender, FormClosingEventArgs e)
        {
            _formMain.cbFormRequesting.Checked = false;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            string id = (sender as Button).Name;

            if (id == "btnPrevious")
            {
                _requestIndex -= 1;
            }
            else if (id == "btnRemove")
            {
                AppRequestModel requestModel = _requests[_requestIndex];

                // api
                _ = _httpApi.ApiRemoveRequest(requestModel);

                // local
                _requests.RemoveAt(_requestIndex);

                int maxIndex = (_requests.Count - 1);
                if (_requestIndex > maxIndex && _requestIndex > 0)
                {
                    _requestIndex -= 1;
                }

            }
            else if (id == "btnNext")
            {
                _requestIndex += 1;
            }

            DisplayButtons();
            DisplayTxts();
        }

        private void DisplayButtons()
        {
            if (_requests.Count == 0)
            {
                btnPrevious.Visible = false;
                btnRemove.Visible = false;
                btnNext.Visible = false;

                lblRequestedTimes.Text = "0";
                lblRequestedTitle.Text = ":)";

                return;
            }

            // previous
            if ((_requestIndex - 1) < 0)
            {
                btnPrevious.Visible = false;
            } else {
                btnPrevious.Visible = true;
            }

            // remove
            if (_requestIndex < _requests.Count && _requestIndex >= 0)
            {
                btnRemove.Visible = true;
            } else {
                btnRemove.Visible = false;
            }

            // next
            if ((_requestIndex + 1) > (_requests.Count - 1))
            {
                btnNext.Visible = false;
            } else {
                btnNext.Visible = true;
            }

        }

        private void DisplayTxts()
        {
            if (_requests.Count == 0) return;

            if (_requestIndex < _requests.Count && _requestIndex >= 0)
            {
                AppRequestModel requestModel = _requests[_requestIndex];

                lblRequestedTitle.Text = Create.AsUrlDeCoded(requestModel.Title);
                lblRequestedTimes.Text = requestModel.RequestedTimes.ToString();
            }
            else
            {
                lblRequestedTitle.Text = "";
                lblRequestedTimes.Text = "";
            }
        }

    }
}
