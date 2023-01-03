using Microsoft.AspNetCore.Http;
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

        public static string UploadImage(IFormFile image)
        {
            var filePath = Path.GetExtension(image.FileName);   
            var randomName = $"{Guid.NewGuid()}{filePath}";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", randomName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return randomName;
        }
    }
}
