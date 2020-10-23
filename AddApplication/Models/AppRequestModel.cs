using Newtonsoft.Json.Linq;
using System;

namespace AddApplication.Models
{
    class AppRequestModel
    {

        public AppRequestModel()
        { }

        public AppRequestModel(JObject jsonData)
        {
            JToken value;

            //

            bool founded = jsonData.TryGetValue("Title", out value);
            if (!founded)
            {
                throw new Exception("Failed getting `Title` from JObject");
            }
            Title = (string)value;

            //

            founded = jsonData.TryGetValue("requested_times", out value);
            if (!founded)
            {
                throw new Exception("Failed getting `requested_times` from JObject");
            }
            RequestedTimes = (int)value;
        }


        public string Title { get; set; }
        public int RequestedTimes { get; set; }





        
    }
}
