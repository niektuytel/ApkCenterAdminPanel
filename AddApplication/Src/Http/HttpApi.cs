using AddApplication.Utils;
using AddApplication.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace AddApplication.Src
{
    class HttpApi
    {

        public HttpApi() 
        { }

        public Dictionary<string, List<ErrorModel>> ApiGetErrors()
        {
            string url = API.IpAddress + API.PathErrors;
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                Console.WriteLine("HttpApi:apiGetErrors(); response not successfully | <response>:" + response.ToString());
            }

            return ResponseAsErrorModels(response.Content);
        }

        public async Task ApiRemoveError(string error_type, ErrorModel error)
        {
            string url = API.IpAddress + API.PathErrorRemove;
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);

            //json
            string jsonToSend = "{ \"error_type\":\"" + error_type + "\",\"error\":\"" + error.Error + "\"}";
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            var response = await client.ExecuteAsync(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("HttpApi:apiRemoveError(); response is not successfully | <response>:" + response.ToString());
            }
        }

        public List<AppRequestModel> ApiGetRequests()
        {
            string url = API.IpAddress + API.PathRequests;
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                Console.WriteLine("HttpApi:apiGetRequests(); response not successfully | <response>:" + response.ToString());
            }

            return ResponseAsRequestModels(response.Content);
        }

        public async Task ApiRemoveRequest(AppRequestModel request_model)
        {
            string url = API.IpAddress + API.PathRequestRemove;
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);

            //json
            string jsonToSend = "{ \"Title\":\"" + request_model.Title + "\"}";
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            var response = await client.ExecuteAsync(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("HttpApi:apiRemoveRequest(); response is not successfully | <response>:" + response.ToString());
            }
        }

        public bool IsApiRemovingApp(string title)
        {
            string url = API.IpAddress + API.PathAppRemove;
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"Title\":\"" + title + "\"\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.IsSuccessful;
        }



        // below ok

        private const string SamplePackage =
               "POST /store/apps/details?id=com.whatsapp HTTP/1.1\r\n" +
               "Host: play.google.com\r\n" +
               "User-Agent: Mozilla/5.0(Windows NT 10.0; Win64; x64; rv: 80.0) Gecko/20100101 Firefox/80.0\r\n" +
               "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8\r\n" +
               "Accept-Language: nl,en-US;q=0.7,en;q=0.3\r\n" +
               "Accept-Encoding: gzip, deflate\r\n" +
               "Upgrade-Insecure-Requests: 1\r\n\r\n" +
               "{\"content\":\"value\"}";


        public Dictionary<string, List<ErrorModel>> ResponseAsErrorModels(string input)
        {
            // create errors
            Dictionary<string, List<ErrorModel>> errors_list = new Dictionary<string, List<ErrorModel>>();

            JObject json_errors = JObject.Parse(input);
            IList<string> keys = json_errors.Properties().Select(p => p.Name).ToList();
            foreach (string key in keys)
            {
                List<ErrorModel> errors = new List<ErrorModel>();
                foreach (JObject item in json_errors.GetValue(key))
                {
                    ErrorModel err_model = new ErrorModel(item);
                    errors.Add(err_model);
                }

                errors_list.Add(key, errors);
            }

            return errors_list;
        }

        public List<AppRequestModel> ResponseAsRequestModels(string input)
        {
            JArray values = JArray.Parse(input);

            List<AppRequestModel> requests = new List<AppRequestModel>();
            foreach (JObject item in values)
            {
                AppRequestModel request_model = new AppRequestModel(item);
                requests.Add(request_model);
            }

            return requests;
        }

        public string[] HeadersAsLines(string package)
        {
            string[] lines = package.Split("\r\n");
            if (lines.Length < 2)
            {
                throw new Exception("The requested Package is invalid <SamplePackage>:" + SamplePackage);
            }

            return lines;
        }

        public string[] HeaderLineAsLine(string headerLine)
        {
            string[] splitted = headerLine.Split(": ");
            if (splitted.Length < 2)
            {
                throw new Exception("The requested Package is invalid <SamplePackage>:" + SamplePackage);
            }

            return splitted;
        }

        public string IsHttp(string variableName, string value)
        {
            if (value is null || variableName is null)
                return "Contains null value";

            if (!value.Contains("http://") && !value.Contains("https://"))
                return variableName + " is not a valid browsable url";
            return "";
        }

    }
}
