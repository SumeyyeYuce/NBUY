using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSitesi.Entity.Concrete
{
    public class Food
    {
        public int Id { get; set; }//ID
        public string Name { get; set; }//Adı
        public string Material { get; set; }//Malzeme
        public string Description { get; set; }//Açıklama
        public string ImageUrl { get; set; }//Resim
        public string Url { get; set; }//url uzantı
        public string IsHome { get; set; }//anasayfa ürünü
        public string IsApproved { get; set; }//Onaylı mı
        public DateTime DateAdded { get; set; }//oluşturulma tarihi
        public int CookingTime { get; set; }//pişirme süresi
        public List<FoodCategory> FoodCategories { get; set; }//hangi categoryde


    }
}
