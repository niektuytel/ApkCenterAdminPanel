using AddApplication.Models;
using AddApplication.Src.FormRequests;
using AddApplication.Src.Http.Api;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AddApplication.Src.AllForms
{
    public partial class FormErrors : Form
    {
        private readonly Dictionary<string, List<ErrorModel>> _allErrors;
        private string _errorType = "";
        private int _errorIndex = 0;

        private readonly FormMain _formMain;
        private readonly ApiError _apiError;
        private readonly EditString _editString;

        public FormErrors(FormMain formMain)
        {
            Icon = Properties.Resources.logo21;

            InitializeComponent();

            _formMain = formMain;
            _editString = new EditString();
            _apiError = new ApiError();

            _allErrors = _apiError.GetAll();
            _errorType = SetErrorType();

            DisplayTexts();
            DisplayButtons();
        }


        private void UpdateFormClosing(object sender, FormClosingEventArgs e)
        {
            _formMain.cbFormErrors.Checked = false;
        }

        private void UpdateErrorType(object sender, EventArgs e)
        {
            _errorType = (sender as ComboBox).Text;
            List<ErrorModel> errorModels = _allErrors[_errorType];

            bool isMatched = false;
            foreach (string errorType in _allErrors.Keys)
            {
                if (errorType == _errorType)
                {
                    isMatched = true;
                }
            }

            if (!isMatched || errorModels.Count <= 0)
            {
                txtError.Text = "";
                return;
            }

            DisplayButtons();
            DisplayTexts();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            string id = (sender as Button).Name;

            if (id == "btnPrevious")
            {
                _errorIndex -= 1;
            }
            else if (id == "btnRemove")
            {
                List<ErrorModel> errors = _allErrors[_errorType];

                // api
                _ = _apiError.Delete(errors[_errorIndex], _errorType);

                // local
                errors.RemoveAt(_errorIndex);

                int max_len = (errors.Count - 1);
                if (_errorIndex > max_len && _errorIndex > 0)
                {
                    _errorIndex -= 1;
                }

            }
            else if (id == "btnNext")
            {
                _errorIndex += 1;
            }

            DisplayButtons();
            DisplayTexts();
        }



        private string SetErrorType()
        {
            // draw error types
            int selectedIndex = cboxErrorType.SelectedIndex;
            cboxErrorType.Items.Clear();

            foreach (string errorType in _allErrors.Keys)
            {
                if (_allErrors[errorType].Count > 0)
                {
                    selectedIndex = 0;
                    cboxErrorType.Items.Add(errorType);
                }
            }

            if (selectedIndex != -1)
            {
                cboxErrorType.SelectedIndex = selectedIndex;
            }

            object error_type = cboxErrorType.SelectedItem;
            return error_type == null ? "" : error_type.ToString();
        }

        private void DisplayButtons()
        {
            if (!_allErrors.ContainsKey(_errorType)) return;

            List<ErrorModel> errors = _allErrors[_errorType];

            // button previous
            if ((_errorIndex - 1) < 0)
            {
                btnPrevious.Visible = false;
            }
            else
            {
                btnPrevious.Visible = true;
            }

            // button remove
            if (_errorIndex < errors.Count && _errorIndex >= 0)
            {
                btnRemove.Visible = true;
            }
            else
            {
                btnRemove.Visible = false;
            }

            // button next
            if ((_errorIndex + 1) > (errors.Count - 1))
            {
                btnNext.Visible = false;
            }
            else
            {
                btnNext.Visible = true;
            }

        }

        private void DisplayTexts()
        {
            if (!_allErrors.ContainsKey(_errorType)) return;

            List<ErrorModel> errors = _allErrors[_errorType];

            if (_errorIndex < errors.Count && _errorIndex >= 0)
            {
                ErrorModel errorModel = errors[_errorIndex];

                txtError.Text = _editString.ConvertToText(errorModel.Error);
                lblTimesError.Text = errorModel.GetRequestedTimes().ToString();
            }
            else
            {
                txtError.Text = "";
                lblTimesError.Text = "";
            }
        }

    }
}