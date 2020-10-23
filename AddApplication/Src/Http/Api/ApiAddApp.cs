using AddApplication.Models;
using AddApplication.Src.AllForms;
using AddApplication.Src.AppAdd;
using AddApplication.Utils;
using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddApplication.Src.Http.Api
{
    public class ApiAddApp
    {

        private readonly FileHelper<AppModel> _fileHelper;
        private const string DownloadingPath = "./Downloaded/";

        public ApiAddApp()
        {
            _fileHelper = new FileHelper<AppModel>();

            if (!Directory.Exists(DownloadingPath))
            {
                Directory.CreateDirectory(DownloadingPath);
            }
        }

        public async Task CreateAppAsync(AppModel application)
        {
            // apk file
            if (application.Apk.Url != null && application.Apk.Url != "")
            {
                string filename = DownloadingPath + ApkFilename(application.Apk.Url);
                try
                {
                    await Task.Run(
                        () => {
                            WebClient client = new WebClient();
                            client.DownloadFile(new Uri(application.Apk.Url), filename);
                        }
                    );

                    if (File.Exists(filename))
                    {
                        FileToApi(filename, application.Title);
                    }

                }
                catch (Exception)
                {
                    DeleteApp(filename);
                    MessageBox.Show("download apk on : " + application.Apk.Url + " Failed"); ;
                    return;
                }

                application.Apk.Url = ApkFilename(application.Apk.Url);
            }

            // json file
            {
                string jsonFile = DownloadingPath + application.Title + ".json";
                await Task.Run(
                    () => _fileHelper.WriteJson(jsonFile, application)
                );

                if (File.Exists(jsonFile))
                {
                    FileToApi(jsonFile, application.Title);
                }
            }


            MessageBox.Show("Creating Application\n" + application.Title + "\n\nSucceeded");

        }

        private bool FileToApi(string filename, string title)
        {
            string url = API.IpAddress + API.PathAppAdd + Create.AsUrlEnCoded(title);

            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddFile("file", filename);

            IRestResponse response = client.Execute(request);

            File.Delete(filename);
            return !response.IsSuccessful;
        }

        private string ApkFilename(string apkUrl)
        {
            if (!apkUrl.Contains("&name="))
            {
                Console.WriteLine("&name= not exists in url, wrong url (ApkFilename)");
                return "";
            }

            string name = apkUrl.Split("&name=")[1].Split("&")[0];
            return name;
        }

        private void DeleteApp(string filename)
        {
            string foldername = "";
            if (File.Exists(filename))
            {
                File.Delete(filename);
                string[] splitted = filename.Split("/");
                string oldFolder = splitted[^1] + "/";

                foldername = filename.Replace(oldFolder, "");
            }

            if (Directory.Exists(foldername))
            {
                Directory.Delete(foldername);
            }

            // delete more here
        }


    }
}
