using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Data.Config;
using YemekSitesi.Data.ExtensionPath;
using YemekSitesi.Entity.Concrete;
using YemekSitesi.Entity.Concrete.Identity;

namespace YemekSitesi.Data.Concrete.EfCore.Contexts
{
    public class YemekSitesiContext :IdentityDbContext<User,Role,string>
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Favorite> Favorites { get; set; }  
        public DbSet<FavoriteItem> FavoriteItems { get; set; }  
        public DbSet<Comment> Comments { get; set; }


        public YemekSitesiContext(DbContextOptions<YemekSitesiContext> options) : base(options)
        {
        
        
        }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.SeedData();
            modelBuilder.ApplyConfiguration(new FoodConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new FoodCategoryConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}
