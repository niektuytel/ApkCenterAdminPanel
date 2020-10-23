using System;
using System.Collections.Generic;
using System.Text;

namespace AddApplication.Models
{
    public class ApiResponseModel
    {
        public ApiResponseModel()
        {
            Headers = new Dictionary<string, string>();
        }

        public ApiResponseModel(RestSharp.IRestResponse package)
        {
            //prepare
            Headers = new Dictionary<string, string>();

            //create
            Code = (int)package.StatusCode;
            foreach (var parameter in package.Headers)
            {
                Headers.Add(parameter.Name, parameter.Value.ToString());
            }
            Body = package.Content;
        }

        public int Code { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Body { get; set; }
    }
}
