using System;
using System.Collections.Generic;
using System.Text;

namespace AddApplication.Utils
{
    class Matched
    {
        public static double Precentage(string value_1, string value_2)
        {
            int total_len = Math.Max(value_1.Length, value_2.Length);

            int chars_matched = 0;
            for (int i = 0; i < total_len; i++)
            {
                if (i < Math.Min(value_1.Length, value_2.Length))
                {
                    if (value_1[i] == value_2[i])
                        chars_matched++;
                }
            }

            return ((double)(chars_matched) / (double)(total_len)) * 100.00;
        }



        public static bool Http(string value)
        {
            return value.Contains("http://") || value.Contains("https://");
        }


    }
}
