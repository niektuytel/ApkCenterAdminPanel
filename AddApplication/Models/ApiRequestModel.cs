using AddApplication.Src;
using AddApplication.Src.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddApplication.Models
{
    public class ApiRequestModel
    {
        private readonly HttpApi _httpApi;

        public ApiRequestModel()
        {
            _httpApi = new HttpApi();
            Headers = new Dictionary<string, string>();
        }

        public ApiRequestModel(string package)
        {
            _httpApi = new HttpApi();
            Headers = new Dictionary<string, string>();
            string[] headerLines = _httpApi.HeadersAsLines(package);

            // create
            Method  = headerLines[0].Split(" ")[0].Replace("\r\n", "");
            Uri     = headerLines[1].Split(" ")[1].Replace("\r\n", "");
            UriPath = headerLines[0].Split(" ")[1].Replace("\r\n", "");

            // headers
            for (int i = 2; i<headerLines.Length; i++)
            {
                string line = headerLines[i].Replace("\r\n", "");

                // skip body
                if (line == "") break;

                string[] headLine = _httpApi.HeaderLineAsLine(line);
                Headers.Add(headLine[0], headLine[1]);
            }

            // body
            if(package.Contains("\r\n\r\n"))
            {
                string header = package.Split("\r\n\r\n")[0];
                Body = package.Replace(header, "");
            }

        }

        public string Method { get; set; }
        public string Uri { get; set; }
        public string UriPath { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Body { get; set; }

    }
}
