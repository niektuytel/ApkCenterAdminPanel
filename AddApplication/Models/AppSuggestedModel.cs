using System.Collections.Generic;

namespace AddApplication.Models
{
    public class AppSuggestedModel
    {
        public AppSuggestedModel()
        {
            Icon = new Dictionary<string, List<string>>();
            Icon.Add("website", new List<string>());
            Icon.Add("apk", new List<string>());

            Images = new Dictionary<string, List<string>>();
            Images.Add("website", new List<string>());
            Images.Add("apk", new List<string>());

            About = new Dictionary<string, List<string>>();
            About.Add("website", new List<string>());
            About.Add("apk", new List<string>());

            Title = new Dictionary<string, List<string>>();
            Title.Add("website", new List<string>());
            Title.Add("apk", new List<string>());

            Category = new Dictionary<string, List<string>>();
            Category.Add("website", new List<string>());
            Category.Add("apk", new List<string>());

            Version = new Dictionary<string, List<string>>();
            Version.Add("website", new List<string>());
            Version.Add("apk", new List<string>());

            ReviewsAmount = new Dictionary<string, List<long>>();
            ReviewsAmount.Add("website", new List<long>());
            ReviewsAmount.Add("apk", new List<long>());

            ReviewsStar = new Dictionary<string, List<double>>();
            ReviewsStar.Add("website", new List<double>());
            ReviewsStar.Add("apk", new List<double>());

            Downloads = new Dictionary<string, List<long>>();
            Downloads.Add("website", new List<long>());
            Downloads.Add("apk", new List<long>());

            Pegi = new Dictionary<string, List<int>>();
            Pegi.Add("website", new List<int>());
            Pegi.Add("apk", new List<int>());
        }


        public Dictionary<string, List<string>> Icon { get; set; }
        public Dictionary<string, List<string>> Images { get; set; }
        public Dictionary<string, List<string>> About { get; set; }
        public Dictionary<string, List<string>> Title { get; set; }
        public Dictionary<string, List<string>> Category { get; set; }
        public Dictionary<string, List<string>> Version { get; set; }
        public Dictionary<string, List<long>> ReviewsAmount { get; set; }
        public Dictionary<string, List<double>> ReviewsStar { get; set; }
        public Dictionary<string, List<long>> Downloads { get; set; }
        public Dictionary<string, List<int>> Pegi { get; set; }

    }

}
