using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace ParcelservicePricing.ConvertedWindowsPhone.extensions
{
    public class WebUtility 
    {
        public static String URLencode(String str, String codec)
        {
            if (codec.Equals("utf-8"))
            {
                return System.Net.WebUtility.UrlEncode(str);
            }
            else throw new ArgumentException("codec nicht unterstützt");
        }
    }
}
