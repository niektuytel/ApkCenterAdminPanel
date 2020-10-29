using AddApplication.Utils;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddApplication.Src.Http.Api
{
    class ApiCategory
    {

        private readonly FileHelper _fileHelper;
        public ApiCategory()
        {
            _fileHelper = new FileHelper();
        }

        public Dictionary<string, Dictionary<string, string>> GetAll()
        {
            string url = API.IpAddress + API.PathCategories;

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            var values = new Dictionary<string, Dictionary<string, string>>();
            if (response.IsSuccessful)
            {
                values = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(response.Content);
            }

            return values;
        }

        public async Task<bool> Add(Dictionary<string, string> body)
        {
            if (!body.ContainsKey("Globally")) return false;
            string url = API.IpAddress + API.PathCategoryAdd;

            return await AddCategory(url, body);
        }

        public async Task<bool> Edit(Dictionary<string,string> body, string selectedValue)
        {
            string url = API.IpAddress + API.PathCategoryEdit + selectedValue;
            return await AddCategory(url, body);
        }

        public async Task<bool> Delete(string category)
        {
            category = Create.AsUrlEnCoded(category);
            string url = API.IpAddress + API.PathCategoryRemove + category;

            var client = new RestClient(url);
            var request = new RestRequest(Method.DELETE);

            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        private async Task<bool> AddCategory(string url, Dictionary<string, string> body)
        {
            string jsonData = _fileHelper.DataToJson(body);

            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("application/json; charset=utf-8", jsonData, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

    }
}
