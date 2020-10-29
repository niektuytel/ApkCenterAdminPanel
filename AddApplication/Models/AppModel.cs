using System.Collections.Generic;

namespace AddApplication.Models
{
    public class AppModel
    {
        public AppModel()
        {
            Category = "";
            Website = new AppWebsiteModel();
            Apk = new AppApkModel();
            Populars = new List<string>();
            TypenApis = new List<string>();
        }

        public string Title { get; set; }
        
        public string Category { get; set; }

        public AppWebsiteModel Website { get; set; }

        public AppApkModel Apk { get; set; }

        public List<string> Types { get; set; }

        public List<string> Populars { get; set; }

        public List<string> TypenApis { get; set; }

        public string Limit { get; set; }

    }
}
