using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core
{
    public static class Jobs
    {
        public static string InitUrl(string url)
        {
            #region acıklamalar
            /*Bu metot kendisine gelen url değişkenin içindeki
             * 1)Latin alfabesine çevrillrken problem çıkaran İ-i,ı-i gibi dönüştürmelri yapıcak
             *  2)diger Türkçe karakterlerin yerne latin alfabeiandeki karşılıklarını koyucak
             * 3)Boşluklar yerine - koyucak
             *4)nokta(.) slaş (/) gibi karakterlei kaldırıcak
             */
            #endregion

            url= url.Replace("I", "i");//url den gelen büyuk I ları Küçük i yapıcak
            url = url.Replace("İ", "i");//url den gelen büyuk İ ları Küçük i yapıcak
            url = url.Replace("ı", "i");

            url=url.ToLower();
           url = url.Replace("İ", "i");//url den gelen büyuk İ ları Küçük i yapıcak

           


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
