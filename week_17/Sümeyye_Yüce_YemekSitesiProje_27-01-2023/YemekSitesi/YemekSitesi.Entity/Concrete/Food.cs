using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSitesi.Entity.Concrete
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateAdded { get; set; }
        public string CookingTime { get; set; }
        public List<FoodCategory> FoodCategories { get; set; }


    }
}
