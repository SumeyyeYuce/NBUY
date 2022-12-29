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

            builder.ToTable("Categories");//Veritabanındaki tablonun adı

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
                //new Category
                //{
                //           Id = 5,
                //           Name = "Sebze",
                //           Description = "Sizler için özenle hazırlanmış Sebze Tariflerimiz burada bulunmaktadır",
                //           Url = "sebze"
                //},
                //new Category
                //{
                //            Id = 6,
                //            Name = "Hamur İşi",
                //            Description = "Sizler için özenle hazırlanmış Hamur İşi Tariflerimiz burada bulunmaktadır",
                //            Url = "hamur-isi"
                //}, 
                //new Category
                //{
                //            Id = 7,
                //            Name = "Salata",
                //            Description = "Sizler için özenle hazırlanmış Salata Tariflerimiz burada bulunmaktadır",
                //            Url = "salata"
                //}, 
                //new Category
                //{
                //            Id = 8,
                //            Name = "Aperatif",
                //            Description = "Sizler için özenle hazırlanmış Aperatif Tariflerimiz burada bulunmaktadır",
                //            Url = "aperatif"
                //}, 
                //new Category
                //{
                //            Id = 9,
                //            Name = "Et Yemekleri",
                //            Description = "Sizler için özenle hazırlanmış Et Yemekleri Tariflerimiz burada bulunmaktadır",
                //            Url = "et-yemekleri"
                //},
                //new Category
                //{
                //             Id = 10,
                //             Name = "Kahvaltılık",
                //             Description = "Sizler için özenle hazırlanmış Kahvaltılık Tariflerimiz burada bulunmaktadır",
                //             Url = "kahvaltılık"
                //}


                );
            
        }
    }
}
