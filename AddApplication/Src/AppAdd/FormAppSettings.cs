using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AddApplication.Src.AppAdd;

namespace AddApplication.Src.AllForms
{
    public partial class FormAppSettings : Form
    {
        public const string FileStorage = "./Storage/settings.json";
        private readonly Category _category;

        private readonly FormAppAdd _formAppAdd;
        private readonly FormHelper<FormAppAdd> _formHelper;

        public FormAppSettings(FormAppAdd formAppAdd)
        {
            Icon = Properties.Resources.logo21;
            _formAppAdd = formAppAdd;
            _category = new Category();
            _formHelper = new FormHelper<FormAppAdd>(formAppAdd);

            InitializeComponent();

            RefreshCategory();            
        }

        private void Form_Closing(Object sender, FormClosingEventArgs e)
        {
            _formAppAdd.cbFormSettings.Checked = false;
        }

        private async void Categories_ButtonClicked(object sender, EventArgs e)
        {
            string id = (sender as Button).Name.ToLower();
            var itemIndex = lstCategories.SelectedIndex;
            var categorySection = FormAppAdd.StorageModel.AllCategories;

            Dictionary<string, string> countryValues = new Dictionary<string, string>
            {
                { "Globally", txtGlobally.Text },// required
                { "Nederland", txtNederland.Text }

                // Add here the rest of the country values that will been added in future times

            };

            // protection
            if (countryValues["Globally"] is "") return;



            _category.IsSelecting = true;
            {
                txtGlobally.Text = "";//required
                txtNederland.Text = "";
                
                // Add here the rest of the country values that will been added in future times

                lstCategories.ClearSelected();

                // api
                string currentItem = "";
                if (itemIndex != -1)
                {
                    currentItem = categorySection["Globally"].ElementAt(itemIndex).Key;
                }

                bool ok = await _category.RequestApi(id, countryValues, currentItem);
                if (!ok) return;
                


                string globallyValue = countryValues["Globally"];
                foreach (KeyValuePair<string, string> countrySection in countryValues)
                {
                    // local
                    if (id.ToLower().Contains("add"))
                    {
                        if ( itemIndex != -1)
                        {
                            categorySection[countrySection.Key].Remove(currentItem);
                        }

                        categorySection[countrySection.Key].Add(globallyValue, countrySection.Value);
                    }
                    else if ( itemIndex != -1)
                    {
                        categorySection[countrySection.Key].Remove(currentItem);
                    }
                }

                _formAppAdd.RefreshLists();
                RefreshCategory();
            }
            _category.IsSelecting = false;
        }

        private void Categories_Selected(object sender, EventArgs e)
        {
            var categorySection = FormAppAdd.StorageModel.AllCategories;
            int index = lstCategories.SelectedIndex;

            if (index == -1 || _category.IsEditing) return;
            string value = lstCategories.SelectedItem.ToString();

            _category.IsSelecting = true;
            {
                txtGlobally.Text = categorySection["Globally"][value];//required
                txtNederland.Text = categorySection["Nederland"][value];

                // Add here the rest of the country values that will been added in future times

            }
            _category.IsSelecting = false;
        }

        private void Categories_EditText(object sender, EventArgs e)
        {
            int index = lstCategories.SelectedIndex;
            if (index == -1 || _category.IsSelecting) return;

            _category.IsEditing = true;
            {
                lstCategories.Items[index] = txtGlobally.Text;
            }
            _category.IsEditing = false;
        }

        private void RefreshCategory()
        {
            var categorySection = FormAppAdd.StorageModel.AllCategories;
            if (!categorySection.ContainsKey("Globally")) return;

            var categoryKeys = categorySection["Globally"].Keys.ToArray();
            _formHelper.DisplayList(categoryKeys, lstCategories);
        }

    }
}
