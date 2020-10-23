using AddApplication.Models;
using RestSharp;
using System.Collections.Generic;

namespace AddApplication.Src.FormRequests
{
    class WebsiteApkCombo
    {
        // url_page = https://apkcombo.com/whatsapp-messenger/com.whatsapp/download/apk
        EditString mEditString;

        public WebsiteApkCombo()
        {
            mEditString = new EditString();
        }

        public AppModel CreateModel(string url_page)
        {
            AppModel model = new AppModel();

            string response_content = GetResponse(url_page);


            model.Title = guessTitle(response_content);
            model.Category = guessCategory(response_content);

            model.Apk.Icon = guessIcon(response_content);
            model.Apk.Images = guessImages(response_content);
            model.Apk.Version = guessApkVersion(response_content);
            model.Apk.Downloads = guessDownloads(response_content);
            model.Apk.Reviews.Star = guessReviewStar(response_content);
            model.Apk.Reviews.Amount = guessReviewAmount(response_content);
            model.Apk.Url = url_page;
            model.Apk.Pegi = guessPegi(response_content);
            model.Apk.About = guessAbout(response_content);

            return model;
        }

        public string GetResponse(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            return response.Content.Split("<section class=\"section\">")[1];
        }

        ////

        private string guessTitle(string content)
        {
            string guessed_title = "";

            if(content.Contains("<p><span>"))
            {
                string value = content.Split("<p><span>")[1];
                guessed_title = value.Split("</span>")[0];
            }

            return guessed_title;
        }

        private string guessIcon(string content)
        {
            string guessed_icon = "";

            if(content.Contains("<img src=\""))
            {
                string value = content.Split("<img src=\"")[1];
                value = value.Split("\" class=\"")[0];
                guessed_icon = value.Split("data-src=\"")[1];
            }

            return guessed_icon;
        }

        private string[] guessImages(string content)
        {
            List<string> guessed_images = new List<string>();

            if(content.Contains("id=\"gallery-screenshots\">"))
            {
                string value = content.Split("id=\"gallery-screenshots\">")[1];
                value = value.Split("</div>")[0];

                string[] splitted = value.Split(" data-src=\"");
                foreach (string split in splitted)
                {
                    if(split.Contains("\" alt=\""))
                    {
                        guessed_images.Add(split.Split("\" alt=\"")[0]);
                    }
                }
                
            }

            string[] images = new string[guessed_images.Count];
            guessed_images.CopyTo(images);
            return images;
        }

        private Dictionary<string, AboutTextModel> guessAbout(string content)
        {
            Dictionary<string, AboutTextModel> guessed_abouts = new Dictionary<string, AboutTextModel>();

            // do not exists in website 

            return guessed_abouts;
        }

        private string guessCategory(string content)
        {
            string guessed_category = "";

            if(content.Contains("<td>Category</td>"))
            {
                string value = content.Split("<td>Category</td>")[1];
                value = value.Split("</a></td>")[0];
                guessed_category = value.Split(">")[1];
            }

            return guessed_category;
        }

        private string guessApkVersion(string content)
        {
            string guessed_version = "";

            if (content.Contains("<span>Version</span>"))
            {
                string value = content.Split("<span>Version</span>")[1];
                value = value.Split("</a>")[0];
                string[] splitted = value.Split(">");

                guessed_version = splitted[splitted.Length - 1];
            }

            return guessed_version;
        }

        private double guessReviewStar(string content)
        {
            double guessed_star = 0;

            // do not contain in website

            return guessed_star;
        }

        private long guessReviewAmount(string content)
        {
            long guessed_amount = 0;

            // do not contain in website 

            return guessed_amount;
        }

        private long guessDownloads(string content)
        {
            long guessed_downloads = 0;

            if(content.Contains("<td>Installs</td><td>"))
            {
                string value = content.Split("<td>Installs</td><td>")[1];
                value = value.Split("</td>")[0];
                guessed_downloads = mEditString.ConvertToLong(value);
            }

            return guessed_downloads;
        }

        private int guessPegi(string content)
        {
            int guessed_pegi = 0;

            // do not contains in website 

            return guessed_pegi;
        }

    }



}

