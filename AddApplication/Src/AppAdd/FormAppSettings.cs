using System;
using System.Windows.Forms;
using AddApplication.Models;
using AddApplication.Src.AppAdd;

namespace AddApplication.Src.AllForms
{
    public partial class FormAppSettings : Form
    {
        public const string FileStorage = "./Storage/settings.json";

        private readonly FormAppAdd _formAppAdd;
        private readonly FileHelper<AppSettingsModel> _fileHelper;
        private readonly FormHelper<FormAppAdd> _formHelper;
        private readonly Category _category;
        private readonly TypenApis _typenApis;

        public FormAppSettings(FormAppAdd formAppAdd)
        {
            Icon = Properties.Resources.logo21;
            _formAppAdd = formAppAdd;
            _fileHelper = new FileHelper<AppSettingsModel>();
            _formHelper = new FormHelper<FormAppAdd>(formAppAdd);
            _category = new Category();
            _typenApis = new TypenApis();

            InitializeComponent();

            RefreshAll();            
        }

        private void Form_Closing(Object sender, FormClosingEventArgs e)
        {
            _formAppAdd.cbFormSettings.Checked = false;
        }

        private async void Categories_ButtonClicked(object sender, EventArgs e)
        {
            int index = lstCategories.SelectedIndex;
            string id = (sender as Button).Name.ToLower();

            CategoryModel model = new CategoryModel
            {
                Globally = txtGlobally.Text,
                Nederland = txtNederland.Text
            };

            //update data
            _category.IsSelecting = true;
            {
                txtNederland.Text = "";
                txtGlobally.Text = "";
                lstCategories.ClearSelected();

                // api
                bool ok = await _category.RequestApi(id, model, index);
                if (!ok) return;

                if(id.ToLower().Contains("add"))
                {
                    if(index is -1)
                    {
                        FormAppAdd.StorageModel.UpdateCategories(model);//add
                    }
                    else
                    {
                        FormAppAdd.StorageModel.Categories[index] = model;// edit
                        FormAppAdd.StorageModel.UpdateCategories();
                    }
                } else if (index != -1) {
                    FormAppAdd.StorageModel.Categories[index].Globally = "";// remove
                    FormAppAdd.StorageModel.UpdateCategories();
                }

                _fileHelper.WriteJson(FileStorage, FormAppAdd.StorageModel);
                _formAppAdd.RefreshLists();
                RefreshCategory();
            }
            _category.IsSelecting = false;
        }

        private void Categories_Selected(object sender, EventArgs e)
        {
            int index = (sender as ListBox).SelectedIndex;
            if (index == -1 || _category.IsEditing) return;

             _category.IsSelecting = true;
            {

                CategoryModel model = FormAppAdd.StorageModel.Categories[index];
                txtGlobally.Text = model.Globally;
                txtNederland.Text = model.Nederland;

            }
            _category.IsSelecting = false;
        }

        private void Categories_EditText(object sender, EventArgs e)
        {
            int index = lstCategories.SelectedIndex;
            if (index == -1 || _category.IsSelecting) return;

            _category.IsEditing = true;
            {

                CategoryModel model = new CategoryModel
                {
                    Globally = txtGlobally.Text,
                    Nederland = txtNederland.Text
                };
                lstCategories.Items[index] = model.Globally;
            }
            _category.IsEditing = false;
        }


        private void ApiTypes_ButtonClicked(object sender, EventArgs e)
        {

            string id = (sender as Button).Name;
            int index = lstApis.SelectedIndex;

            ApiTypeModel model = new ApiTypeModel
            {
                ApiName = txtApiName.Text,
                ApiPath = txtApiPath.Text
            };

            //update data
            _category.IsSelecting = true;
            {
                txtApiName.Text = "";
                txtApiPath.Text = "";
                lstApis.ClearSelected();

                if (id.ToLower().Contains("add"))
                {
                    if (index is -1)
                    {
                        FormAppAdd.StorageModel.UpdateApiTypes(model);//add
                    }
                    else
                    {
                        FormAppAdd.StorageModel.ApiTypes[index] = model;// edit
                        FormAppAdd.StorageModel.UpdateApiTypes();
                    }
                }
                else if (index != -1)
                {
                    FormAppAdd.StorageModel.ApiTypes[index].ApiName = "";// remove
                    FormAppAdd.StorageModel.UpdateApiTypes();
                }

                // save
                _fileHelper.WriteJson(FileStorage, FormAppAdd.StorageModel);
                _formAppAdd.RefreshLists();
                RefreshTypenApis();
            }
            _category.IsSelecting = false;
        }

        private void ApiTypes_Selected(object sender, EventArgs e)
        {
            int index = (sender as ListBox).SelectedIndex;
            if (index == -1 || _typenApis.IsEditing) return;

            _typenApis.IsSelecting = true;
            {

                ApiTypeModel model = FormAppAdd.StorageModel.ApiTypes[index];
                txtApiName.Text = model.ApiName;
                txtApiPath.Text = model.ApiPath;
    
            }
            _typenApis.IsSelecting = false;
        }

        private void ApiTypes_EditText(object sender, EventArgs e)
        {
            int index = lstApis.SelectedIndex;
            if (index == -1 || _typenApis.IsSelecting) return;

            _typenApis.IsEditing = true;
            {

                ApiTypeModel model = FormAppAdd.StorageModel.ApiTypes[index];
                model.ApiName = txtApiName.Text;
                model.ApiPath = txtApiPath.Text;

                lstApis.Items[index] = model.ApiName;

            }
            _typenApis.IsEditing = false;

        }

        // NO Events
        private void RefreshAll()
        {
            RefreshCategory();
            RefreshTypenApis();
        }

        private void RefreshCategory()
        {
            string[] categories = _category.ModelToString(FormAppAdd.StorageModel.Categories);
            _formHelper.DisplayList(categories, lstCategories);
        }

        private void RefreshTypenApis()
        {
            string[] apiTypes = _typenApis.ModelToString(FormAppAdd.StorageModel.ApiTypes);
            _formHelper.DisplayList(apiTypes, lstApis);
        }

    }
}
