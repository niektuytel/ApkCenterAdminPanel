using AddApplication.Models;
using AddApplication.Src.AllForms;
using AddApplication.Src.Http.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddApplication.Src.AppAdd
{
    class Category
    {

        private readonly AppSettingsModel _storage;
        private readonly ApiCategory _apiCategory;
        private readonly InitializeHelper _initializeHelper;

        public bool IsSelecting = false;
        public bool IsEditing = false;

        public Category()
        {
            _storage = FormAppAdd.StorageModel;
            _apiCategory = new ApiCategory();
            _initializeHelper = new InitializeHelper();

        }

        public async Task<bool> RequestApi(string buttonId, CategoryModel category, int selectedIndex = -1)
        {
            if (category.IsInvalid()) return false;

            if (buttonId.Contains("add"))
            {
                if (selectedIndex != -1)
                {
                    // edit
                    CategoryModel oldModel = _storage.Categories[selectedIndex];
                    return await _apiCategory.EditCategory(category, oldModel);
                }
                else
                {
                    // add
                    return await _apiCategory.AddCategory(category);
                }
            }
            else if (buttonId.Contains("remove"))
            {
                // remove
                return await _apiCategory.RemoveCategory(category);
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
