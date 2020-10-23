using AddApplication.Utils;
using System;
using System.Text;

namespace AddApplication.Src.FormRequests
{
    class EditString
    {
        public EditString() 
        { }

        public string SetCharacters(string text)
        {
            text = text.Replace("\\n", "\r\n");
            text = text.Replace("\\t", "\t");
            return text;
        }

        public string ConvertToText(string input)
        {
            try
            {
                byte[] data = Convert.FromBase64String(input);
                input = Encoding.UTF8.GetString(data);
            }
            catch (Exception)
            { }

            input = Create.AsUrlDeCoded(input);
            input = SetCharacters(input);
            return input;
        }

        public long ConvertToLong(string input)
        {
            input = input.Replace(",", "");
            input = input.Replace("+", "");
            input = input.Replace(".", "");

            _ = long.TryParse(input, out long longValue);

            return longValue;
        }

    }
}
