using BlogApp.Data.Concrete.EntityFramework.Mapings;
using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Contexts
{
    public class BlogAppContext:DbContext
    {
        public DbSet<Article>  Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OFVK2FD; Database=BlogAppDb; Integrated Security=true; TrustServerCertificate=true");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());

        }
    }
}

//EntityFrameworkCore 7 ile SqlServer veritaınıa baglantı ile ilgili öenmli değişiklij olmuştur
//buda güvenlik amacıyla dogrulamış sertifika gereksinimleri Bunu ifade eden TrustServerCertificate
//özelliği (devamını hocadan al)