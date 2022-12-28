using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Data.Concrete.EfCore.Contexts
{
    public class YemekSitesiContext :DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=YemekSitesi.db");
        }
    }
}
