using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(c => c.Url)
                .IsRequired()
                .HasMaxLength(250);

            builder.ToTable("Categories");

            builder.HasData(
                
                new Category
                {
                        Id=1,
                        Name="Çorba",
                        Description="Sizler için özenle hazırlanmış Çorba Tariflerimiz burada bulunmaktadır",
                        Url="corba"
                },              
                new Category
                {
                         Id = 2,
                         Name = "Kurabiye",
                         Description = "Sizler için özenle hazırlanmış Kurabiye Tariflerimiz burada bulunmaktadır",
                         Url = "kurabiye"
                },
                new Category
                {
                          Id = 3,
                          Name = "Tatlı",
                          Description = "Sizler için özenle hazırlanmış Tatlı Tariflerimiz burada bulunmaktadır",
                          Url = "tatlı"
                }
               


                );
            
        }
    }
}
