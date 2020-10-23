using System;
using System.Collections.Generic;
using System.Linq;
using AddApplication.Models;
using AddApplication.Src.AllForms;
using AddApplication.Utils;

namespace AddApplication.Src
{
    class AutoFillWebsite
    {
        private readonly AppSuggestedModel _suggested;

        public AutoFillWebsite(AppSuggestedModel suggested)
        {
            _suggested = suggested;
        }

        public bool HasInfo(string value)
        {
            bool hasInfo = false;
            AppModel application = FormAppAdd.ApplicationModel;

            if(application.Title != value && _suggested.Title["apk"].Count == 0)
            {
                string guessTitle = GuessTitle(value);
                if(guessTitle != "" && !Matched(value, _suggested.Title["website"]))
                {
                    application.Title = guessTitle;
                    _suggested.Title["website"].Add(guessTitle);
                    hasInfo = true;
                }
            }

            if (application.Category != null)
            {
                if (application.Category != value && _suggested.Category["apk"].Count == 0)
                {
                    string guess_category = GuessCategory(value);
                    if (guess_category != "" && !Matched(value, _suggested.Category["website"]))
                    {
                        application.Category = guess_category;
                        _suggested.Category["website"].Add(guess_category);
                        hasInfo = true;
                    }
                }
            }

            return hasInfo;
        }

        private string GuessTitle(string value)
        {
            //get domain_name
            string domainName = value;
            domainName = domainName.Replace("https://www.", "");
            domainName = domainName.Replace("http://www.", "");
            domainName = domainName.Replace("https://", "");
            domainName = domainName.Replace("http://", "");
            domainName = domainName.Split("/")[0];
            domainName = string.Concat(domainName.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
            domainName = Create.UppercaseWords(domainName);

            return domainName;
        }

        private string GuessCategory(string value)
        {
            string categoryName = "";

            //TODO: need some way on how to handle this but idk for now

            foreach (CategoryModel category in FormAppAdd.StorageModel.Categories)
            {
                if (category.Globally == value)
                    categoryName = category.Globally;
            }

            return categoryName;
        }

        private bool Matched(string value1, List<string> values2)
        {
            foreach (string value2 in values2)
            {
                string longest  = (value1.Length > value2.Length) ? value1 : value2;
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

        private static double Precentage(string value1, string value2)
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

            return (charsMatched / totalLength) * 100.00;
        }

    }
}
