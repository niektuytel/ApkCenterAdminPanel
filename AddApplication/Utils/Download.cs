using System;
using System.Drawing;

namespace AddApplication.Utils
{
    class Download
    {
        public static Image ImageFromUrl(string imageUrl)
        {

            System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
            webRequest.AllowWriteStreamBuffering = true;
            webRequest.Timeout = 30000;
            try
            {
                System.Net.WebResponse webResponse = webRequest.GetResponse();
                System.IO.Stream stream = webResponse.GetResponseStream();
                Image image = System.Drawing.Image.FromStream(stream);

                webResponse.Close();
                return image;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
