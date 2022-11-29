using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mapings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);//primaryKey demiş olduk(Article için).
            builder.Property(a=>a.Id).ValueGeneratedOnAdd();//ıd nin identity (birer birer) olarak çalışmasını saglicak.

            builder.Property(a => a.Title).IsRequired();//başlığın zorunlu olması demek.(varsayılanı true)
            builder.Property(a=>a.Title).HasMaxLength(100);//max 100 karakter demek

            builder.Property(a=>a.Content).IsRequired(); 
            builder.Property(a=>a.Content).HasColumnType("NVARCHAR(MAX)");//bunu vermessek varchar yapıyor.

            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);

            builder.Property(a => a.Date).IsRequired();
            
            builder.Property(a=>a.SeoAuthor).IsRequired();  
            builder.Property(a=>a.SeoAuthor).HasMaxLength(50);

            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoDescription).HasMaxLength(150);

            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);

            builder.Property(a => a.ViewsCount).IsRequired();

            builder.Property(a => a.CommentCount).IsRequired();

            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);

            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);

            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();

            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();

            builder.Property(a => a.Note).HasMaxLength(500);

            builder.HasOne(c => c.Category).WithMany(a => a.Articles).HasForeignKey(a => a.CategoryId);//tek tarafı kategory çok tarafı articel dedik

            builder.HasOne(u => u.User)
                .WithMany(a => a.Articles)
                .HasForeignKey(a => a.UserId);

            builder.ToTable("Articles");

            //ilk articel verilerinin eklenmesi

            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId=1,
                    UserId=1,
                    Title="C# 11.0 Yenilikleri",
                    Content= "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    Thumbnail="default.jpg",
                    SeoDescription= "C# 11.0 Yenilikleri",
                    SeoTags="C#, C# 11.0, DotNet 6, DotNet 7, DotNet Core",
                    SeoAuthor="Deniz Gezen",
                    ViewsCount=116,
                    CommentCount=1,
                    Date=DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 11.0 Yenilikleri"
                },
                 new Article
                 {
                     Id = 2,
                     CategoryId = 2,
                     UserId = 1,
                     Title = "Modern Javascript",
                     Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                     Thumbnail = "default.jpg",
                     SeoDescription = "Modern Javascript",
                     SeoTags = "Ecma script 6, map,filter, reduce,Arrow Funciton",
                     SeoAuthor = "Deniz Gezen",
                     ViewsCount = 193,
                     CommentCount = 1,
                     Date = DateTime.Now,
                     IsActive = true,
                     IsDeleted = false,
                     CreatedByName = "InitialCreated",
                     CreatedDate = DateTime.Now,
                     ModifiedByName = "InitialCreated",
                     ModifiedDate = DateTime.Now,
                     Note = "Modern Javascript"
                 },
                  new Article
                  {
                      Id = 3,
                      CategoryId = 3,
                      UserId = 2,
                      Title = "React Component yapısı",
                      Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                      Thumbnail = "default.jpg",
                      SeoDescription = "React Component yapısı",
                      SeoTags = "React,React js, component,state,class,funcion componet",
                      SeoAuthor = "Deniz Gezen",
                      ViewsCount = 225,
                      CommentCount = 1,
                      Date = DateTime.Now,
                      IsActive = true,
                      IsDeleted = false,
                      CreatedByName = "InitialCreated",
                      CreatedDate = DateTime.Now,
                      ModifiedByName = "InitialCreated",
                      ModifiedDate = DateTime.Now,
                      Note = "React Component yapısı"
                  }
                );




        }
    }
}
//Burada EfCore tarafında default convetion yöntemiyle kendiliğinden gerçekleşen olayları el ile 
//yapmı olucagız.(devamını hocadan al)