using AddApplication.Models;
using AddApplication.Utils;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AddApplication.Src.Http.Api
{
    public class ApiApp
    {
        private const string DownloadingPath = "./Downloaded/";


        private readonly FileHelper _fileHelper;

        public ApiApp()
        {
            _fileHelper = new FileHelper();

            if (!Directory.Exists(DownloadingPath))
            {
                Directory.CreateDirectory(DownloadingPath);
            }
        }

        public bool Delete(string title)
        {
            string url = API.IpAddress + API.PathAppRemove;
            var client = new RestClient(url);
            var request = new RestRequest(Method.DELETE);

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"Title\":\"" + title + "\"\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.IsSuccessful;
        }

        public async Task<bool> AddAsync(AppModel application)
        {
            List<string> fileNames = new List<string>();
            string filename = "";

            // apk file
            if (application.Apk.Url != null && application.Apk.Url != "")
            {
                filename = DownloadingPath + GetApkFilename(application.Apk.Url);
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
                        fileNames.Add(filename);
                    }
                }
                catch (Exception)
                {
                    DeleteFile(filename);
                    //MessageBox.Show("download apk on : " + application.Apk.Url + " Failed"); ;
                    return false;
                }

                application.Apk.Url = GetApkFilename(application.Apk.Url);
            }

            // json file
            filename = DownloadingPath + application.Title + ".json";
            await Task.Run( () => _fileHelper.WriteJson(filename, application) );

            if (!File.Exists(filename)) return false;
            fileNames.Add(filename);

            AddFiles(fileNames.ToArray(), application.Title);
            //MessageBox.Show("Creating Application\n" + application.Title + "\n\nSucceeded");

            return true;
        }


        private bool AddFiles(string[] filenames, string title)
        {
            string url = API.IpAddress + API.PathAppAdd + title;
            var client = new RestClient(url)
            {
                Timeout = -1
            };

            var request = new RestRequest(Method.POST);
            foreach (string filename in filenames)
            {
                request.AddFile("files", filename);
            }

            IRestResponse response = client.Execute(request);
            foreach (string filename in filenames)
            {
                File.Delete(filename);
            }

            return !response.IsSuccessful;
        }

        private void DeleteFile(string filename)
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

        private string GetApkFilename(string apkUrl)
        {
            if (!apkUrl.Contains("&name="))
            {
                Console.WriteLine("&name= not exists in url, wrong url (ApkFilename)");
                return "";
            }

            string name = apkUrl.Split("&name=")[1].Split("&")[0];
            return name;
        }

    }
}
