using AddApplication.Models;
using AddApplication.Src.Http.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddApplication.Src.AppAdd
{
    class Category
    {

        private readonly ApiCategory _apiCategory;

        public bool IsSelecting = false;
        public bool IsEditing = false;

        public Category()
        {
            _apiCategory = new ApiCategory();
        }

        public async Task<bool> RequestApi(string buttonId, Dictionary<string, string> categories, string selectedValue = "")
        {
            if (buttonId.ToLower().Contains("add"))
            {
                if (selectedValue is "")
                {
                    // add
                    return await _apiCategory.Add(categories);
                }
                else
                {
                    // edit
                    return await _apiCategory.Edit(categories, selectedValue);
                }
            }
            else if (buttonId.Contains("remove") && selectedValue != "")
            {
                // remove
                return await _apiCategory.Delete(selectedValue);
            }

            Console.WriteLine("<buttonId>:" + buttonId + " can't been found :( | Category.cs::RequestCategory()");
            return false;
        }

        public string[] ModelToString(CategoryModel[] models)
        {
            int length = 0;
            if (models != null) length = models.Length;

            string[] categories = new string[length];
            for (int i = 0; i < length; i++)
            {
                categories[i] = models[i].Globally;
            }

            return categories;
        }

    }
}
