using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSitesi.Core
{
    public static  class Works
    {
        public static string InitUrl(string url)
        {
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");

            url = url.ToLower();
            url = url.Replace("İ", "i");

            url = url.Replace("ş", "s")
               .Replace("ö", "o")
               .Replace("ü", "u")
               .Replace("ç", "c")
               .Replace("ğ", "g")
               .Replace("ı", "i")
               .Replace(" ", "-")
               .Replace(".", "")
               .Replace("/", "")
               .Replace("\\", "")
               .Replace("(", "")
               .Replace(")", "")
               .Replace("[", "")
               .Replace("]", "")
               .Replace("{", "")
               .Replace("\"", "")
               .Replace("}", "");
            return url;
        }
    }
}
