using Newtonsoft.Json.Linq;
using System;

namespace AddApplication.Models
{
    class ErrorModel
    {
        public ErrorModel() { }

        public ErrorModel(JObject json_data)
        {
            JToken value;

            //

            bool founded = json_data.TryGetValue("error", out value);
            if(!founded)
            {
                throw new Exception("Failed getting `error` from JObject");
            }
            Error = (string)value;

            //

            founded = json_data.TryGetValue("requested_times", out value);
            if(!founded)
            {
                throw new Exception("Failed getting `requested_times` from JObject");
            }
            RequestedTimes = (int)value;
        }

        public string Error { get; set; }

        public int RequestedTimes { get; set; }

    }
}
