using AddApplication.Models;
using AddApplication.Utils;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace AddApplication.Src.Http.Api
{
    class ApiCategory
    {

        public ApiCategory()
        { }

        public CategoryModel[] Categories()
        {
            string url = API.IpAddress + API.PathCategories;

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            CategoryModel[] values = null;
            if (response.IsSuccessful)
            {
                values = JsonConvert.DeserializeObject<CategoryModel[]>(response.Content);
            }

            return values;
        }

        public async Task<bool> AddCategory(CategoryModel model)
        {
            string url = API.IpAddress + API.PathCategoryAdd;
            string jsonToSend = JsonConvert.SerializeObject(model);

            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> EditCategory(CategoryModel model, CategoryModel oldModel)
        {
            CategoryModel[] dataModel = new CategoryModel[2];
            dataModel[0] = oldModel;
            dataModel[1] = model;

            string url = API.IpAddress + API.PathCategoryEdit;
            string jsonToSend = JsonConvert.SerializeObject(dataModel);

            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> RemoveCategory(CategoryModel model)
        {
            string name = Create.AsUrlEnCoded(model.Globally);
            string url = API.IpAddress + API.PathCategoryRemove + "?name=" + name;

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

    }
}
