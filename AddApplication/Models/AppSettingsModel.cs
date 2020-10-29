
using AddApplication.Src;
using System.Collections.Generic;

namespace AddApplication.Models
{
    public class AppSettingsModel
    {
        private readonly InitializeHelper _initializeHelper;

        public AppSettingsModel()
        {
            _initializeHelper = new InitializeHelper();
        }


        public Dictionary<string, Dictionary<string, string>> AllCategories { get; set; }
        public string[] Pegi { get; set; }
        public string[] Country { get; set; }
        public ApiTypeModel[] ApiTypes { get; set; }


        //public void UpdateCategories(Dictionary<string, string> newCategory = null)
        //{
        //    List<CategoryModel> newValues = new List<CategoryModel>();
        //    bool founded = false;

        //    foreach (CategoryModel category in Categories)
        //    {
        //        if (category.Globally != "")
        //        {
        //            // update value
        //            if(
        //                !founded && addModel != null && 
        //                addModel.Globally == category.Globally
        //            ){
        //                founded = true;
        //                category.Nederland = addModel.Nederland;
        //            }

        //            newValues.Add(category);
        //        }
        //    }

        //    // add new value
        //    if(
        //        !founded && addModel != null && 
        //        addModel.Globally != null &&
        //        addModel.Nederland != null
        //    ){
        //        newValues.Add(addModel);
        //    }

        //    Categories = _initializeHelper.Array<CategoryModel>(newValues.Count);
        //    newValues.CopyTo(Categories);
        //}

        public void UpdateApiTypes(ApiTypeModel addModel = null)
        {
            List<ApiTypeModel> newValues = new List<ApiTypeModel>();
            bool founded = false;

            foreach (ApiTypeModel type in ApiTypes)
            {
                if (type.ApiName != "")
                {
                    // update value
                    if (
                        !founded && addModel != null &&
                        addModel.ApiName == type.ApiName
                    )
                    {
                        founded = true;
                        type.ApiPath = addModel.ApiPath;
                    }

                    newValues.Add(type);
                }
            }

            // add new value
            if (
                !founded && addModel != null &&
                addModel.ApiName != null &&
                addModel.ApiPath != null
            )
            {
                newValues.Add(addModel);
            }

            ApiTypes = _initializeHelper.Array<ApiTypeModel>(newValues.Count);
            newValues.CopyTo(ApiTypes);
        }
    }

    public class ApiTypeModel
    {
        public string ApiPath { get; set; }
        public string ApiName { get; set; }
    }

}
