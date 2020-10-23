using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AddApplication.Models;
using System.Drawing;
using AddApplication.Src.AppAdd;
using AddApplication.Src.Http.Api;

namespace AddApplication.Src.AllForms
{
    public partial class FormAppAdd : Form
    {
        public bool RefreshingUI = false;
        public static AppModel ApplicationModel;
        public static AppSettingsModel StorageModel;

        private readonly FormMain _formMain = null;
        private readonly FileHelper<AppSettingsModel> _fileHelper;
        private readonly FormHelper<FormAppAdd> _formHelper;
        private readonly TypenApis _typenApis;
        private readonly Category _category;
        private readonly AddApp _addApp;
        private readonly ApiCategory _apiCategory;
        private readonly ApiCountry _apiCountry;

        private FormPhone _formPhone = null;
        private FormAppSettings _formSettings = null;
        private AutoFill _autoFill;


        public FormAppAdd(FormMain formMain)
        {
            Icon = Properties.Resources.logo21;

            _formMain = formMain;
            _fileHelper = new FileHelper<AppSettingsModel>();
            _formHelper = new FormHelper<FormAppAdd>(this);
            _addApp = new AddApp(this);
            _category = new Category();
            _typenApis = new TypenApis();
            _apiCategory = new ApiCategory();
            _apiCountry = new ApiCountry();


            InitializeComponent();

            RefreshAll();
        }

        private void UpdateFormClosing(object sender, FormClosingEventArgs e)
        {
            cbFormSettings.Checked = false;
            cbFormPhone.Checked = false;
            _formMain.cbFormAddApp.Checked = false;
        }

        private void LabelClicked(object sender, EventArgs e)
        {
            lblThreads.Text = _addApp.FinishedTasks.ToString() + "/" + _addApp.RunningTasks.ToString();
        }
        
        private void ButtonClicked(object sender, EventArgs e)
        {
            string id = (sender as Button).Name;

            if(id == btnAddApplication.Name)
            {
                _ = _addApp.CreateAppAsync(lblThreads);
            }
        }

        private void FormSettings_CheckBox(object sender, EventArgs e)
        {
            bool isChecked = (sender as CheckBox).Checked;
            _formHelper.DisplayForm(isChecked, ref _formSettings);
        }

        private async void FormPhone_CheckBox(object sender, EventArgs e)
        {
            bool isChecked = (sender as CheckBox).Checked;
            _formHelper.DisplayForm(isChecked, ref _formPhone);

            if (isChecked && _formPhone != null)
            {
                await _formPhone.UpdateAllAsync();
            }
        }

        private async void ApkUrl_EditText(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            string name = (sender as TextBox).Name;
            AppApkModel apk = ApplicationModel.Apk;

            if (!RefreshingUI)
            {
                apk.Url = _addApp.RefreshData(apk.Url, txtApkUrl);
            }

            if(text.Length == 0)
            {
                panel_apk.Visible = false;
                panel_apk2.Visible = false;
            }
            else
            {
                panel_apk.Visible = true;
                panel_apk2.Visible = true;
            }

            // auto filling
            await _autoFill.SearchAllAsync(text, name);
            _addApp.MakeButtonVisible(btnAddApplication);
        }
        
        private async void WebsiteUrl_EditText(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            string name = (sender as TextBox).Name;
            AppWebsiteModel website = ApplicationModel.Website;

            if (!RefreshingUI)
            {
                website.Url = _addApp.RefreshData(website.Url, txtWebsiteUrl);
            }

            // auto filling
            await _autoFill.SearchAllAsync(text, name);
            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private async void IconUrl_EditText(object sender, EventArgs e)
        {
            AppApkModel apk = ApplicationModel.Apk;

            if (!RefreshingUI)
            {
                apk.Icon = _addApp.RefreshData(apk.Icon, txtIconUrl);
            }

            if(_formPhone != null)
            {
                await _formPhone.UpdateIconAsync(apk.Icon);
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private async void Images_EditText(object sender, EventArgs e)
        {
            AppApkModel apk = ApplicationModel.Apk;
            string name = (sender as TextBox).Name;

            if (!RefreshingUI)
            {
                if(name == txtImageUrl1.Name)
                    apk.Images[0] = _addApp.RefreshData(apk.Images[0], txtImageUrl1);
                else if (name == txtImageUrl2.Name)
                    apk.Images[1] = _addApp.RefreshData(apk.Images[1], txtImageUrl2);
                else if (name == txtImageUrl3.Name)
                    apk.Images[2] = _addApp.RefreshData(apk.Images[2], txtImageUrl3);
                else if (name == txtImageUrl4.Name)
                    apk.Images[3] = _addApp.RefreshData(apk.Images[3], txtImageUrl4);
                else if (name == txtImageUrl5.Name)
                    apk.Images[4] = _addApp.RefreshData(apk.Images[4], txtImageUrl5);
                else if (name == txtImageUrl6.Name)
                    apk.Images[5] = _addApp.RefreshData(apk.Images[5], txtImageUrl6);
            }

            if(_formPhone != null)
            {
                await _formPhone.UpdateImagesAsync(apk.Images);
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void TextAbout_EditText(object sender, EventArgs e)
        {
            AppApkModel apk = ApplicationModel.Apk;
            string text = (sender as TextBox).Text;
            string country = cbbAboutCountry.SelectedItem.ToString();

            if (!RefreshingUI)
            {
                apk.About[country].Text = text;
            }

            // update form phone
            if (_formPhone != null)
            {
                if (apk.About.ContainsKey(country))
                {
                    _formPhone.UpdateAbout(apk.About[country].Text);
                }
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void CountryAbout_ComboBox(object sender, EventArgs e)
        {
            AppApkModel apk = ApplicationModel.Apk;
            string country = cbbAboutCountry.SelectedItem.ToString();
            txtAbout.Visible = true;

            if (apk.About.ContainsKey(country))
            {
                txtAbout.Text = apk.About[country].Text;
            } else {
                txtAbout.Text = "";
            }

            if (!RefreshingUI)
            {
                apk.About[country].Text = _addApp.RefreshData(apk.About[country].Text, txtAbout);
            }

            if (_formPhone != null)
            {
                // update form phone
                if (apk.About.ContainsKey(country))
                {
                    _formPhone.UpdateAbout(apk.About[country].Text);
                }
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void Title_EditText(object sender, EventArgs e)
        {
            AppModel application = ApplicationModel;
            if (!RefreshingUI)
            {
                application.Title = _addApp.RefreshData(application.Title, txtTitle);
            }

            if (_formPhone != null)
            {
                _formPhone.UpdateTitle(ApplicationModel.Title);
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void Category_ComboBox(object sender, EventArgs e)
        {
            AppModel application = ApplicationModel;
            if (!RefreshingUI)
            {
                application.Category = _addApp.RefreshData(application.Category, cbbCategory);
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void ApkVersion_EditText(object sender, EventArgs e)
        {
            AppApkModel apk = ApplicationModel.Apk;
            if (!RefreshingUI)
            {
                apk.Version = _addApp.RefreshData(apk.Version, txtApkVersion);
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void Reviews_EditText(object sender, EventArgs e)
        {
            ReviewsModel review = ApplicationModel.Apk.Reviews;

            if (!RefreshingUI)
            {
                double.TryParse(_addApp.RefreshData(review.Star.ToString(), txtReviewStar), out double star);
                if (star > 0.00)
                    review.Star = star;

                long.TryParse(_addApp.RefreshData(review.Amount.ToString(), txtReviewTotal), out long amount);
                if (amount > 0)
                    review.Amount = amount;
            }

            if (_formPhone != null)
            {
                _formPhone.UpdateReviewStar(review.Star.ToString());
                _formPhone.UpdateReviewTotal(review.Amount);
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void Downloads_EditText(object sender, EventArgs e)
        {
            AppApkModel apk = ApplicationModel.Apk;

            if (!RefreshingUI)
            {
                long.TryParse(_addApp.RefreshData(apk.Downloads.ToString(), txtDownloadsTotal), out long downloads);
                if (downloads > 0)
                    apk.Downloads = downloads;
            }

            if (_formPhone != null)
            {
                long downloads = ApplicationModel.Apk.Downloads;
                _formPhone.UpdateDownloadsTotal(downloads);
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void Pegi_ComboBox(object sender, EventArgs e)
        {
            AppApkModel apk = ApplicationModel.Apk;
            if (!RefreshingUI)
            {
                int.TryParse(_addApp.RefreshData(apk.Pegi.ToString(), cbbPegi), out int pegi);
                apk.Pegi = pegi;
            }

            if (_formPhone != null)
            {
                var pegi = ApplicationModel.Apk.Pegi;
                _formPhone.UpdatePegi(pegi);
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void Popular_CheckList(object sender, EventArgs e)
        {

            if (!RefreshingUI)
            {
                ApplicationModel.Popular = new List<string>();
                foreach (object itemChecked in (sender as CheckedListBox).CheckedItems)
                {
                    string item = (string)itemChecked;
                    ApplicationModel.Popular.Add(item);
                }

                (sender as CheckedListBox).ClearSelected();
            }

            _addApp.MakeButtonVisible(btnAddApplication);

        }

        private void TypenApis_CheckList(object sender, EventArgs e)
        {
            if(!RefreshingUI)
            {
                ApplicationModel.TypenApis = new List<string>();
                foreach (object itemChecked in (sender as CheckedListBox).CheckedIndices)
                {
                    string item = itemChecked.ToString();
                    ApplicationModel.TypenApis.Add(item);
                }            
            
                (sender as CheckedListBox).ClearSelected();
            }


            _addApp.MakeButtonVisible(btnAddApplication);
        }

        private void Limit_ComboBox(object sender, EventArgs e)
        {
            string value = (sender as ComboBox).SelectedItem.ToString();

            if(!RefreshingUI)
            {
                ApplicationModel.Limit = value;
            }

            _addApp.MakeButtonVisible(btnAddApplication);
        }


        //NO EVENTS

        public void RefreshAll()
        {
            StorageModel = _fileHelper.ReadJson(FormAppSettings.FileStorage, new AppSettingsModel());
            StorageModel.Categories = _apiCategory.Categories();
            StorageModel.Country = _apiCountry.Countries();

            ApplicationModel = new AppModel();

            RefreshUI();
            RefreshLists();
            RefreshPhone();

            _autoFill = new AutoFill(this);
        }

        public void RefreshUI()
        {
            AppModel application = ApplicationModel;
            AppApkModel apk = ApplicationModel.Apk;
            AppWebsiteModel website = ApplicationModel.Website;

            RefreshingUI = true;
            {
                txtTitle.Text = application.Title;
                cbbCategory.SelectedItem = application.Category;
                txtApkUrl.Text = apk.Url;
                txtIconUrl.Text = apk.Icon;
                txtApkVersion.Text = apk.Version;
                txtWebsiteUrl.Text = website.Url;

                if (apk.Images.Length > 0)
                    txtImageUrl1.Text = apk.Images[0];
                if (apk.Images.Length > 1)
                    txtImageUrl2.Text = apk.Images[1];
                if (apk.Images.Length > 2)
                    txtImageUrl3.Text = apk.Images[2];
                if (apk.Images.Length > 3)
                    txtImageUrl4.Text = apk.Images[3];
                if (apk.Images.Length > 4)
                    txtImageUrl5.Text = apk.Images[4];
                if (apk.Images.Length > 5)
                    txtImageUrl6.Text = apk.Images[5];

                if (apk.Reviews.Star > 0)
                    txtReviewStar.Text = apk.Reviews.Star.ToString();

                if (apk.Reviews.Amount > 0)
                    txtReviewTotal.Text = apk.Reviews.Amount.ToString();

                if (apk.Downloads > 0)
                    txtDownloadsTotal.Text = apk.Downloads.ToString();

                if (apk.Pegi > 0)
                    cbbPegi.SelectedItem = apk.Pegi.ToString();

                if (
                    apk.About.ContainsKey("Globally") &&
                    apk.About["Globally"].Text != "" &&
                    apk.About["Globally"].Text != null
                )
                {
                    txtAbout.Text = apk.About[cbbAboutCountry.SelectedItem.ToString()].Text;
                }
            }
            RefreshingUI = false;
        }

        public void RefreshLists()
        {
            string[] categoryNames = _category.ModelToString(StorageModel.Categories);
            string[] apiNames = _typenApis.ModelToString(StorageModel.ApiTypes);

            _formHelper.DisplayList(categoryNames, cbbCategory);
            _formHelper.DisplayList(apiNames, cLstTypesApi);
            _formHelper.DisplayList(StorageModel.Pegi, cbbPegi);
            _formHelper.DisplayList(StorageModel.Country, cbbAboutCountry);
            _formHelper.DisplayList(StorageModel.Country, cLstPopular);

            // default
            if (cbbAboutCountry.Items.Count > 0)
            {
                cbbAboutCountry.SelectedIndex = 0;
            }

            if (cbbPegi.Items.Count > 0)
            {
                cbbPegi.SelectedIndex = 0;
            }

            if (cbbLimitCount.Items.Count > 0)
            {
                cbbLimitCount.SelectedIndex = 0;
            }

            if (cLstPopular.Items.Count > 0)
            {
                cLstPopular.SetItemChecked(0, true);
                string value = cLstPopular.Items[0].ToString();
                ApplicationModel.Popular = new List<string>() { value };
            }

        }

        private void RefreshPhone()
        {
            if (cbFormPhone.Checked)
            {
                int current_x = 20;
                int current_y = 20;

                if (_formPhone != null)
                {
                    current_x = _formPhone.Location.X;
                    current_y = _formPhone.Location.Y;

                    _formPhone.Close();
                }

                // location
                _formPhone.WindowState = FormWindowState.Normal;
                _formPhone.StartPosition = FormStartPosition.Manual;
                _formPhone.BringToFront();
                _formPhone.Location = new Point(current_x, current_y);

                _formPhone.Show();
            }
        }

    }
}
