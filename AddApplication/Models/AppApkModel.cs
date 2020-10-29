using AddApplication.Src.AllForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddApplication.Models
{
    public class AppApkModel
    {
        public AppApkModel()
        {
            Reviews = new ReviewsModel();
            Images = new string[] { "", "", "", "", "", "" };
            Abouts = new Dictionary<string, AboutTextModel>();
            if(FormAppAdd.StorageModel.Country != null)
            {
                foreach (string country in FormAppAdd.StorageModel.Country)
                {
                    Abouts.Add(country, new AboutTextModel());
                }
            }

        }

        public string Url { get; set; } = "";

        public string Version { get; set; }

        public string Icon { get; set; }

        public ReviewsModel Reviews { get; set; }

        public long Downloads { get; set; }

        public int Pegi { get; set; }

        public string[] Images { get; set; }

        public Dictionary<string, AboutTextModel> Abouts { get; set; }

    }

    public class ReviewsModel
    {
        public double Star { get; set; }

        public long Amount { get; set; }
    }

    public class AboutTextModel
    {
        public string Text { get; set; }
    }

    public class PackageModel
    {
        public PackageModel()
        {
            ResponseSplitReplacement = new List<List<string>>();
            UsingNextPackage = new List<string>();
        }

        public string Package { get; set; }
        public List<List<string>> ResponseSplitReplacement { get; set; }
        public List<string> UsingNextPackage { get; set; }
    }

}
