using AddApplication.Models;
using AddApplication.Utils;
using RestSharp;
using System.Collections.Generic;

namespace AddApplication.Src.Http
{
    class WebsiteGooglePlay
    {

        public WebsiteGooglePlay()
        { }

        public ApiResponseModel Search(string apkName, string country = "Globally")
        {
            string language = "";
            if (country == "Nederland")
                language = "Accept-Language: nl,en-US;q=0.7,en;q=0.3\r\n";

            string path = "";
            if (country == "Nederland")
                path = "/store/apps/details?id=" + apkName + "&gl=NL";
            else
                path = "/store/apps/details?id=" + apkName;

            string package =
                "GET " + path + " HTTP/1.1\r\n" +
                "Host: play.google.com\r\n" +
                "User-Agent: Mozilla/5.0(Windows NT 10.0; Win64; x64; rv: 80.0) Gecko/20100101 Firefox/80.0\r\n" +
                "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8\r\n" +
                language +
                "Accept-Encoding: gzip, deflate\r\n" +
                "Upgrade-Insecure-Requests: 1\r\n\r\n";


            // request package
            ApiRequestModel requestModel = new ApiRequestModel(package);


            var client = new RestClient("https://" + requestModel.Uri + requestModel.UriPath);
            var request = new RestRequest();
            foreach (KeyValuePair<string, string> entry in requestModel.Headers)
            {
                request.AddHeader(entry.Key, entry.Value);
            }

            return new ApiResponseModel(client.Get(request));
        }
    }
}
