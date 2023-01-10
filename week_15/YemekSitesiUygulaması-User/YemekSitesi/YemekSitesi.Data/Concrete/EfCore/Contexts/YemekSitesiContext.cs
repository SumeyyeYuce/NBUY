using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Data.Config;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Data.Concrete.EfCore.Contexts
{
    public class YemekSitesiContext :DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }


       public YemekSitesiContext(DbContextOptions<YemekSitesiContext> options) : base(options)
       {
        
        
       }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.ApplyConfiguration(new FoodConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new FoodCategoryConfig());
        }

    }
}
