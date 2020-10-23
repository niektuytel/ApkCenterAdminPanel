using AddApplication.Models;
using AddApplication.Src.AllForms;
using System;
using System.Windows.Forms;

namespace AddApplication.Src
{
    class FormHelper<TForm>
    {
        private readonly TForm _formMain;

        public FormHelper( TForm mainForm)
        {
            _formMain = mainForm;
        }

        public void DisplayForm<T>(bool isChecked, ref T form)
        {
            if (isChecked && form == null)
            {
                form = (T)Activator.CreateInstance(typeof(T), _formMain);
                (form as Form).Show();
            }
            else if (form != null)
            {
                (form as Form).Close();
                form = default(T);
            }
        }

        public void DisplayList(string[] values, ListBox list)
        {
            int selectedIndex = list.SelectedIndex;

            // clean
            list.Items.Clear();

            // create
            if (values != null)
            {
                foreach (string value in values)
                {
                    list.Items.Add(value);
                }
            }
            
            if (list.Items.Count > selectedIndex)
            {
                list.SelectedIndex = selectedIndex;
            }
        }

        public void DisplayList(string[] values, ComboBox list)
        {
            int selectedIndex = list.SelectedIndex;

            // clean
            list.DataSource = null;
            list.Items.Clear();

            // create
            if (values != null)
            {
                foreach (string value in values)
                {
                    list.Items.Add(value);
                }
            }

            if (list.Items.Count > selectedIndex)
            {
                list.SelectedIndex = selectedIndex;
            }
        }



    }
}
