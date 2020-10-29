using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AddApplication.Models;
using AddApplication.Src.Http.Api;
using AddApplication.Utils;

namespace AddApplication.Src.AllForms
{
    public partial class FormAppRequests: Form
    {
        private readonly List<AppRequestModel> _allRequests;
        private int _requestIndex = 0;

        private readonly FormMain _formMain;
        private readonly ApiRequest _apiRequest;


        public FormAppRequests(FormMain formMain)
        {
            this.Icon = Properties.Resources.logo21;

            InitializeComponent();

            _formMain = formMain;
            _apiRequest = new ApiRequest();

            _allRequests = _apiRequest.GetAll();

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
                AppRequestModel requestModel = _allRequests[_requestIndex];

                // api
                _ = _apiRequest.Delete(requestModel);

                // local
                _allRequests.RemoveAt(_requestIndex);

                int maxIndex = (_allRequests.Count - 1);
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
            if (_allRequests.Count == 0)
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
            if (_requestIndex < _allRequests.Count && _requestIndex >= 0)
            {
                btnRemove.Visible = true;
            } else {
                btnRemove.Visible = false;
            }

            // next
            if ((_requestIndex + 1) > (_allRequests.Count - 1))
            {
                btnNext.Visible = false;
            } else {
                btnNext.Visible = true;
            }

        }

        private void DisplayTxts()
        {
            if (_allRequests.Count == 0) return;

            if (_requestIndex < _allRequests.Count && _requestIndex >= 0)
            {
                AppRequestModel requestModel = _allRequests[_requestIndex];

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
