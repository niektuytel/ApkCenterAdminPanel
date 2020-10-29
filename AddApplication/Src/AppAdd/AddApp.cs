using AddApplication.Models;
using AddApplication.Src.AllForms;
using AddApplication.Src.Http.Api;
using AddApplication.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddApplication.Src.AppAdd
{
    public class AddApp
    {
        public int FinishedTasks { get; set; }
        public int RunningTasks { get; set; }

        private readonly FormAppAdd _formAppAdd;
        private readonly HttpApi _httpApi;
        private readonly ApiApp _apiAddApp;

        public AddApp(FormAppAdd formAppAdd)
        {
            _formAppAdd = formAppAdd;
            _apiAddApp = new ApiApp();
            _httpApi = new HttpApi();

        }

        public void MakeButtonVisible(Button button)
        {
            string error = AppCreatable();

            if (button.Visible is false && error is "")
            {
                button.Visible = true;
            }
            else if (button.Visible is true && error != "")
            {
                button.Visible = false;
            }
        }

        public string RefreshData(string oldValue, object uiObject)
        {
            if (uiObject is TextBox)
            {
                string newValue = (uiObject as TextBox).Text;
                if (newValue != oldValue)
                {
                    return newValue;
                }
            }
            else if (uiObject is ComboBox)
            {
                string newValue = (string)(uiObject as ComboBox).SelectedItem;
                if (newValue != oldValue)
                {
                    return newValue;
                }
            }

            return oldValue;
        }

        private string AppCreatable()
        {
            AppModel application = FormAppAdd.ApplicationModel;
            AppApkModel apk = FormAppAdd.ApplicationModel.Apk;
            AppWebsiteModel website = FormAppAdd.ApplicationModel.Website;

            string message = "";

            if (application.TypenApis.Count == 0)
            {
                return "Typen Apis is Empty, should at least select the `Globally` country";
            }

            if (application.Limit is "")
            {
                return "Limit should contain at least some information";
            }

            if (!application.Title.Any(char.IsUpper))
            {
                return "Title missing Capital Letter[s]";
            }

            if (!application.Category.Any(char.IsUpper))
            {
                return "Category missing Capital Letter[s]";
            }

            List<string> types = new List<string>();
            if (apk.Url != null && apk.Url != "")
            {
                if (!apk.Url.Contains(".apk") && !apk.Url.Contains(".xapk"))
                {
                    return "apk url is invalid should end with \".apk\"/\".xapk\"";
                }

                if (!File.Exists(apk.Url))
                {
                    if (_httpApi.IsHttp("apk", application.Apk.Url) != "")
                        return "apk url Don't Exists in your Device.";
                }

                // images
                foreach (string image in apk.Images)
                {
                    if (image == "") continue;

                    message = _httpApi.IsHttp("images", image);
                    if (message != "" && !message.ToLower().Contains("null"))
                    {
                        return message;
                    }
                }

                // icon
                message = _httpApi.IsHttp("icon", apk.Icon);
                if (message != "")
                {
                    return message;
                }


                // downloads
                if (!long.TryParse(apk.Downloads.ToString(), out _))
                {
                    return "downloads -> Total IS Number (123)";
                }

                // reviews
                if (!double.TryParse(apk.Reviews.Star.ToString(), out _))
                {
                    return "reviews -> Star IS Comma-separated value (1.2)";
                }

                if (!long.TryParse(apk.Reviews.Amount.ToString(), out _))
                {
                    return "reviews -> Total IS Number (123)";
                }

                // pegi
                if (!int.TryParse(apk.Pegi.ToString(), out _))
                {
                    return "pegi -> Age IS Number (3)";
                }

                types.Add("Apk");
            }


            if (website.Url != null && website.Url != "")
            {
                // website
                message = _httpApi.IsHttp("website", website.Url);
                if (message != "") return message;

                types.Add("Website");
            }

            application.Types = types;
            return "";
        }

        public async Task CreateAppAsync(Label label)
        {
            string error = AppCreatable();
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }

            // create
            string finished = FinishedTasks.ToString();
            string running = RunningTasks++.ToString();
            AppModel application = FormAppAdd.ApplicationModel;
            application.Title = Create.AsUrlEnCoded(application.Title);

            label.Text = finished + "/" + running;
            {

                _formAppAdd.RefreshAll();
                await Task.Run(
                    () => _apiAddApp.AddAsync(application)
                );
                finished = (FinishedTasks++).ToString();

            }
            label.Text = finished + "/" + running;
        }


    }
}
