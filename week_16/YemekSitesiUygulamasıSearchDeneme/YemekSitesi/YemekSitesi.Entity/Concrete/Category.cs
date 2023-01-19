using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSitesi.Entity.Concrete
{
    public class Category
    {
        public int Id { get; set; }//Id
        public string Name { get; set; }//Adı    
        public string Description { get; set; }//Açıklaması
        public string Url { get; set; }//uzantı
        public List<FoodCategory> FoodCategories { get; set; }//hani yemek hangi kategoride

    }
}
