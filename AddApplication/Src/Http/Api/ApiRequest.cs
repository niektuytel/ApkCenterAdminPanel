using AddApplication.Models;
using AddApplication.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddApplication.Src.Http.Api
{
    class ApiRequest
    {
        public ApiRequest()
        { }

        public List<AppRequestModel> GetAll()
        {
            string url = API.IpAddress + API.PathRequests;
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                Console.WriteLine("HttpApi:apiGetRequests(); response not successfully | <response>:" + response.ToString());
            }

            return JsonConvert.DeserializeObject<List<AppRequestModel>>(response.Content);
        }

        public async Task<bool> Delete(AppRequestModel model)
        {
            string url = API.IpAddress + API.PathRequestRemove;
            var client = new RestClient(url);
            var request = new RestRequest(Method.DELETE);

            //json
            string jsonToSend = "{ \"Title\":\"" + model.Title + "\"}";
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            var response = await client.ExecuteAsync(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("HttpApi:apiRemoveRequest(); response is not successfully | <response>:" + response.ToString());
                return false;
            }

            return true;
        }

    }
}
