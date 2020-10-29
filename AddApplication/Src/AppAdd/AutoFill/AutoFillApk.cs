using System;
using System.Collections.Generic;
using System.Web;
using AddApplication.Models;
using AddApplication.Src.AllForms;
using AddApplication.Src.Http;
using AddApplication.Utils;

namespace AddApplication.Src
{
    class AutoFillApk
    {
        private readonly AppSuggestedModel _suggestedModel;
        private ApiResponseModel _responseModel;

        private readonly WebsiteGooglePlay _googlePlay;
        private readonly HttpApi _httpApi;

        public AutoFillApk(AppSuggestedModel suggested)
        {
            _suggestedModel = suggested;
            _googlePlay = new WebsiteGooglePlay();
            _httpApi = new HttpApi();
        }


        public bool HasInfo(string value)
        {
            bool hasInfo = false;
            AppModel application = FormAppAdd.ApplicationModel;


            string packageName = PackageName(value);
            if (packageName != "")
            {
                // search on googleplay
                _responseModel = _googlePlay.Search(packageName);
                if (_responseModel.Code != 200)
                {
                    // todo: try other websites
                    return false;
                }



                //title
                if (application.Title != value)
                {
                    string guessTitle = GuessTitle();
                    if (guessTitle != "" && !Matched(guessTitle, _suggestedModel.Title["apk"]) && !Matched(guessTitle, _suggestedModel.Title["website"]))
                    {
                        application.Title = guessTitle;
                        _suggestedModel.Title["apk"].Add(guessTitle);
                        hasInfo = true;
                    }
                }

                //Category
                if(application.Category != value)
                {
                    string guessCategory = GuessCategory();
                    if(guessCategory != "" && !Matched(guessCategory, _suggestedModel.Category["apk"]) && !Matched(guessCategory, _suggestedModel.Category["website"]))
                    {
                        application.Category = guessCategory;
                        _suggestedModel.Category["apk"].Add(guessCategory);
                        hasInfo = true;
                    }
                }

                //version
                if (application.Apk.Version != value)
                {
                    string guessVersion = GuessVersion(value);
                    if(guessVersion != "" && !Matched(guessVersion, _suggestedModel.Version["apk"]) && !Matched(guessVersion, _suggestedModel.Version["website"]))
                    {
                        application.Apk.Version = guessVersion;
                        _suggestedModel.Version["apk"].Add(guessVersion);
                        hasInfo = true;
                    }
                }
            
                //reviews
                if (application.Apk.Reviews.Amount.ToString() != value)
                {
                    long guessAmount = GuessReviewsAmount();
                    if (guessAmount != 0 && !Matched(guessAmount, _suggestedModel.ReviewsAmount["apk"]) && !Matched(guessAmount, _suggestedModel.ReviewsAmount["website"]))
                    {
                        application.Apk.Reviews.Amount = guessAmount;
                        _suggestedModel.ReviewsAmount["apk"].Add(guessAmount);
                        hasInfo = true;
                    }
                }

                if (application.Apk.Reviews.Star.ToString() != value)
                {
                    double guessStar = GuessReviewsStar();
                    if (guessStar != 0 && !Matched(guessStar, _suggestedModel.ReviewsStar["apk"]) && !Matched(guessStar, _suggestedModel.ReviewsStar["website"]))
                    {
                        application.Apk.Reviews.Star = guessStar;
                        _suggestedModel.ReviewsStar["apk"].Add(guessStar);
                        hasInfo = true;
                    }
                }

                //downloads
                if (application.Apk.Downloads.ToString() != value)
                {
                    long guessDownloads = GuessDownloads();
                    if (guessDownloads != 0 && !Matched(guessDownloads, _suggestedModel.Downloads["apk"]) && !Matched(guessDownloads, _suggestedModel.Downloads["website"]))
                    {
                        application.Apk.Downloads = guessDownloads;
                        _suggestedModel.Downloads["apk"].Add(guessDownloads);
                        hasInfo = true;
                    }
                }

                //pegi
                if (application.Apk.Pegi.ToString() != value)
                {
                    int guessPegi = GuessPegi();
                    if (guessPegi != 0 && !Matched(guessPegi, _suggestedModel.Pegi["apk"]) && !Matched(guessPegi, _suggestedModel.Pegi["website"]))
                    {
                        application.Apk.Pegi = guessPegi;
                        _suggestedModel.Pegi["apk"].Add(guessPegi);
                        hasInfo = true;
                    }
                }


                //icon
                if (application.Apk.Icon != value)
                {
                    string guessIcon = GuessIcon();
                    if(guessIcon != "" && !Matched(guessIcon, _suggestedModel.Icon["apk"]) && !Matched(guessIcon, _suggestedModel.Images["website"]))
                    {
                        application.Apk.Icon = guessIcon;
                        _suggestedModel.Icon["apk"].Add(guessIcon);
                        hasInfo = true;
                    }
                }


                // update images
                for (int i = 0; i < application.Apk.Images.Length; i++)
                {
                    if (application.Apk.Images[i] != value)
                    {
                        string guessImage = GuessImage(i);
                        if(guessImage != "" && !Matched(guessImage, _suggestedModel.Images["apk"]) && !Matched(guessImage, _suggestedModel.Images["website"]))
                        {
                            application.Apk.Images[i] = guessImage;
                            _suggestedModel.Images["apk"].Add(guessImage);
                            hasInfo = true;
                        }
                    }
                }


                //about
                {
                    // have already
                    string currentCountry = "Globally";

                    // api supported
                    Dictionary<string, string> supportedCountries = new Dictionary<string, string>
                    {
                        { "Globally", "" },
                        { "Nederland", "" }
                    };

                    foreach (KeyValuePair<string, string> country_item in supportedCountries)
                    {
                        // add new element
                        if (!application.Apk.Abouts.ContainsKey(country_item.Key))
                            application.Apk.Abouts.Add(country_item.Key, new AboutTextModel());

                        if (application.Apk.Abouts[country_item.Key].Text != value)
                        {
                            // request new packages (if not currentCountry)
                            if (country_item.Key != currentCountry)
                            {
                                // request googleplay (new language content)
                                _responseModel = _googlePlay.Search(packageName, country_item.Key);
                                if (_responseModel.Code != 200)
                                    return false;// todo: try other websites
                            }

                            // create content
                            string guess_about = GuessAbout();
                            if(guess_about != "" && !Matched(guess_about, _suggestedModel.About["apk"]) && !Matched(guess_about, _suggestedModel.About["website"]))
                            {
                                application.Apk.Abouts[country_item.Key].Text = guess_about;
                                _suggestedModel.About["apk"].Add(guess_about);
                                hasInfo = true;
                            }
                        }
                    }

                    //remove duplicate
                    {
                        var globallyAbout = application.Apk.Abouts["Globally"];
                        var nederlandAbout = application.Apk.Abouts["Nederland"];

                        if(globallyAbout.Text != null && nederlandAbout.Text != null)
                        {
                            if ( globallyAbout.Text.Contains(nederlandAbout.Text))
                            {
                                globallyAbout.Text = globallyAbout.Text.Replace(nederlandAbout.Text, "");
                            }
                            else if(nederlandAbout.Text.Contains(globallyAbout.Text))
                            {
                                nederlandAbout.Text = nederlandAbout.Text.Replace(globallyAbout.Text, "");
                            }
                        }
                    }
                }
            }

            return hasInfo;
        }

        private string GuessIcon()
        {
            string iconName = "";

            // ........<div class="xSyT2c"><img src="https://......." srcset........
            if (_responseModel.Body.Contains("<div class=\"xSyT2c\"><img src=\""))
            {
                iconName = _responseModel.Body.Split("<div class=\"xSyT2c\"><img src=\"")[1];
                iconName = iconName.Split("\" srcset")[0];
            }

            // check
            if (_httpApi.IsHttp("icon name", iconName) is "")
                return iconName;
            return "";
        }

        private string GuessImage(int index)
        {
            string imageName = "";

            //......data-screenshot-item-index="^ index ^"......src="https://......" srcset=
            if (_responseModel.Body.Contains("data-screenshot-item-index=\"" + index.ToString() +"\""))
            {
                imageName = _responseModel.Body.Split("data-screenshot-item-index=\"" + index.ToString() + "\"")[1];
                
                if (imageName.Contains("\""))
                    imageName = imageName.Split("\"")[1];
                else
                    return "";

            }

            // check 
            if (_httpApi.IsHttp("image name", imageName) is "" && imageName.Contains("googleusercontent.com"))
                return imageName;
            return "";
        }

        private string GuessAbout()
        {
            string content = "";

            ////// ............<meta itemprop="description" content=".........."><h2 aria-label="Description">
            if (_responseModel.Body.Contains("<meta itemprop=\"description\" content=\""))
            {
                content = _responseModel.Body.Split("<meta itemprop=\"description\" content=\"")[1];
                content = content.Split("\"><h2 aria-label=")[0];
                content = content.Replace("&#39;", "'");
                content = content.Replace("&quot;", "\"");

            }
            return content;
        }

        private string GuessTitle()
        {
            string titleName = "";

            // ...... itemprop=\"name\"><span >WhatsApp Messenger</span></h1><c-data.....
            if (_responseModel.Body.Contains(" itemprop=\"name\"><span >"))
            {
                titleName = _responseModel.Body.Split(" itemprop=\"name\"><span >")[1];
                titleName = titleName.Split("</span></h1><c-data")[0];
                titleName = titleName.Replace("&amp;", "&");
            }

            return titleName;
        }

        private string GuessCategory()
        {
            string value = "";

            // ....../store/apps/category/COMMUNICATION"........
            if (_responseModel.Body.Contains("/store/apps/category/"))
            {
                string[] splitted = _responseModel.Body.Split("/store/apps/category/");
                value = splitted[^1];
                value = value.Split("\"")[0];
                value = value.Replace("_AND_", " & ");
                value = Create.UppercaseWords(value.ToLower());
            }

            //check
            var categories = FormAppAdd.StorageModel.AllCategories["Globally"];
            foreach (string category in categories.Keys)
            {
                if (value.ToLower().Contains(category.ToLower()))
                {
                    return category;
                }
            }

            return "";
        }

        private string GuessVersion(string value)
        {
            string versionName = "";

            //....&name=whatsapp-messenger_2.20.199.14.apk&.....
            if (value.Contains("&name="))
            {
                versionName = value.Split("&name=")[1];
                versionName = versionName.Split("&")[0];
                versionName = versionName.Replace(".apk", "");
                versionName = versionName.Replace(".xapk", "");
                if (versionName.Contains("_"))
                    versionName = versionName.Split("_")[1];
                versionName = HttpUtility.UrlDecode(versionName);

            }

            // check 
            if (versionName.Contains("."))
                return versionName;
            return "";
        }

        private long GuessReviewsAmount()
        {
            // ......>121,228,127</span> total</span>.........
            string value = _responseModel.Body.Split("</span> total</span>")[0];
            string[] splitted = value.Split(">");
            value = splitted[^1].Replace(",", "").Replace(".", "");
            long.TryParse(value, out long reviewsAmount);

            return reviewsAmount;
        }

        private double GuessReviewsStar()
        {
            double reviewsStar = 0;

            // .....<div class="BHMmbe"....>4.3</div>.........
            if (_responseModel.Body.Contains("<div class=\"BHMmbe\""))
            {
                string container = _responseModel.Body.Split("<div class=\"BHMmbe\"")[1];
                container = container.Split("</div>")[0];
                container = container.Split(">")[1];
                double.TryParse(container, out reviewsStar);
            }

            return reviewsStar;
        }

        private long GuessDownloads()
        {
            // .....>5,000,000,000+</span>.........
            string value = _responseModel.Body.Split("+</span>")[0];
            string[] splitted = value.Split(">");
            value = splitted[^1];
            value = value.Replace(",", "").Replace(".", "");
            long.TryParse(value, out long downloads);
           
            return downloads;
        }

        private int GuessPegi()
        {
            int pegiAge = 0;

            // .....PEGI 3">.........
            if (_responseModel.Body.Contains("PEGI "))
            {
                string container = _responseModel.Body.Split("PEGI ")[1];
                container = container.Split("\">")[0];
                int.TryParse(container, out pegiAge);
            }

            foreach (string item in FormAppAdd.StorageModel.Pegi)
            {
                if (item == pegiAge.ToString())
                    return pegiAge;
            }

            return 0;
        }

        private bool Matched(string value1, List<string> values2)
        {
            foreach (string value2 in values2)
            {
                string longest = (value1.Length > value2.Length) ? value1 : value2;
                string shortest = (value1.Length < value2.Length) ? value1 : value2;

                if (longest.Contains(shortest))
                {
                    double percentage = Precentage(value1.ToLower(), value2.ToLower());
                    if (percentage > 80.00)
                        return true;
                }
            }

            return false;
        }

        private bool Matched(long value1, List<long> values2)
        {
            foreach (long value2 in values2)
            {
                if (value1 == value2) return true;
            }

            return false;
        }

        private bool Matched(double value1, List<double> values2)
        {
            // value to double

            foreach (double value2 in values2)
            {
                if (value1 == value2) return true;
            }

            return false;
        }

        private bool Matched(int value1, List<int> values2)
        {
            foreach (int value2 in values2)
            {
                if (value1 == value2) return true;
            }

            return false;
        }


        private string PackageName(string value)
        {
            string packageName = "";
            value = HttpUtility.UrlDecode(value);

            if(value.Contains("&package_name="))
            {
                string[] splitted = value.Split("&package_name=");
                if(splitted.Length > 1)
                {
                    string item = splitted[^1];
                    packageName = item.Split("&")[0];
                }
            }

            return packageName;
        }

        private double Precentage(string value1, string value2)
        {
            int totalLength = Math.Max(value1.Length, value2.Length);

            int charsMatched = 0;
            for (int i = 0; i < totalLength; i++)
            {
                if (i < Math.Min(value1.Length, value2.Length))
                {
                    if (value1[i] == value2[i])
                        charsMatched++;
                }
            }

            return charsMatched / totalLength * 100.00;
        }

    }
}
