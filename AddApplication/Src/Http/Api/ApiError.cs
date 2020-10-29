using AddApplication.Models;
using AddApplication.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AddApplication.Src.Http.Api
{
    class ApiError
    {
        public ApiError()
        { }

        public Dictionary<string, List<ErrorModel>> GetAll()
        {
            string url = API.IpAddress + API.PathErrors;
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                Console.WriteLine("HttpApi:apiGetErrors(); response not successfully | <response>:" + response.ToString());
            }

            return JsonConvert.DeserializeObject<Dictionary<string, List<ErrorModel>>>(response.Content);
        }

        public async Task<bool> Delete(ErrorModel errorModel, string errorType)
        {
            string url = API.IpAddress + API.PathErrorRemove;
            var client = new RestClient(url);
            var request = new RestRequest(Method.DELETE);

            //json
            errorModel.ErrorType = errorType;
            string jsonData = JsonConvert.SerializeObject(errorModel);
            request.AddParameter("application/json; charset=utf-8", jsonData, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            var response = await client.ExecuteAsync(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("HttpApi:apiRemoveError(); response is not successfully | <response>:" + response.ToString());
                return false;
            }

            return true;
        }

    }


}
