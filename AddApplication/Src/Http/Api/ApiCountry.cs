using AddApplication.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace AddApplication.Src.Http.Api
{
    class ApiCountry
    {

        public ApiCountry()
        { }

        public string[] Countries()
        {
            string url = API.IpAddress + API.PathCountries;

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            string[] values = null;
            if (response.IsSuccessful)
            {
                values = JsonConvert.DeserializeObject<string[]>(response.Content);
            }

            return values;
        }

    }
}
