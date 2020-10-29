using System;

namespace AddApplication.Src
{
    class HttpApi
    {

        public HttpApi() 
        { }

        private const string SamplePackage =
               "POST /store/apps/details?id=com.whatsapp HTTP/1.1\r\n" +
               "Host: play.google.com\r\n" +
               "User-Agent: Mozilla/5.0(Windows NT 10.0; Win64; x64; rv: 80.0) Gecko/20100101 Firefox/80.0\r\n" +
               "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8\r\n" +
               "Accept-Language: nl,en-US;q=0.7,en;q=0.3\r\n" +
               "Accept-Encoding: gzip, deflate\r\n" +
               "Upgrade-Insecure-Requests: 1\r\n\r\n" +
               "{\"content\":\"value\"}";

        public string[] HeadersAsLines(string package)
        {
            string[] lines = package.Split("\r\n");
            if (lines.Length < 2)
            {
                throw new Exception("The requested Package is invalid <SamplePackage>:" + SamplePackage);
            }

            return lines;
        }

        public string[] HeaderLineAsLine(string headerLine)
        {
            string[] splitted = headerLine.Split(": ");
            if (splitted.Length < 2)
            {
                throw new Exception("The requested Package is invalid <SamplePackage>:" + SamplePackage);
            }

            return splitted;
        }

        public string IsHttp(string variableName, string value)
        {
            if (value is null || variableName is null)
                return "Contains null value";

            if (!value.Contains("http://") && !value.Contains("https://"))
                return variableName + " is not a valid browsable url";
            return "";
        }

    }
}
