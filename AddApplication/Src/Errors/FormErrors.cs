using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AddApplication.Models;
using AddApplication.Src.FormRequests;

namespace AddApplication.Src.AllForms
{
    public partial class FormErrors: Form
    {
        private readonly FormMain _formMain;
        private readonly HttpApi _httpApi;
        private readonly EditString _editString;
        private readonly Dictionary<string, List<ErrorModel>> _errors;

        private string _errorType = "";
        private int _errorIndex = 0;

        public FormErrors(FormMain formMain)
        {
            Icon = Properties.Resources.logo21;

            InitializeComponent();

            _formMain = formMain;
            _httpApi = new HttpApi();
            _editString = new EditString();
            _errors = _httpApi.ApiGetErrors();
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
            List<ErrorModel> errors = _errors[_errorType];

            bool isMatched = false;
            foreach (string errorType in _errors.Keys)
            {
                if(errorType == _errorType)
                {
                    isMatched = true;
                }
            }

            if (!isMatched || errors.Count <= 0)
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
                List<ErrorModel> errors = _errors[_errorType];
                
                // api
                _ = _httpApi.ApiRemoveError(_errorType, errors[_errorIndex]);

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
            int index_error_type = cboxErrorType.SelectedIndex;
            cboxErrorType.Items.Clear();

            foreach (string section_key in _errors.Keys)
            {
                if(_errors[section_key].Count > 0)
                {
                    index_error_type = 0;
                    cboxErrorType.Items.Add(section_key);
                }
            }

            if (index_error_type != -1)
            {
                cboxErrorType.SelectedIndex = index_error_type;
            }

            object error_type = cboxErrorType.SelectedItem;
            return error_type == null ? "" : error_type.ToString();
        }

        private void DisplayButtons()
        {
            if(!_errors.ContainsKey(_errorType)) return;

            List<ErrorModel> errors = _errors[_errorType];

            // button previous
            if ((_errorIndex - 1) < 0)
            {
                btnPrevious.Visible = false;
            } else {
                btnPrevious.Visible = true;
            }

            // button remove
            if (_errorIndex < errors.Count && _errorIndex >= 0)
            {
                btnRemove.Visible = true;
            } else {
                btnRemove.Visible = false;
            }

            // button next
            if ((_errorIndex + 1) > (errors.Count - 1))
            {
                btnNext.Visible = false;
            } else {
                btnNext.Visible = true;
            }

        }

        private void DisplayTexts()
        {
            if (!_errors.ContainsKey(_errorType)) return;

            List<ErrorModel> errors = _errors[_errorType];

            if ( _errorIndex < errors.Count && _errorIndex >= 0)
            {
                ErrorModel errorModel = errors[_errorIndex];

                txtError.Text = _editString.ConvertToText(errorModel.Error);
                lblTimesError.Text = errorModel.RequestedTimes.ToString();
            }
            else
            {
                txtError.Text = "";
                lblTimesError.Text = "";
            }
        }

    }
}