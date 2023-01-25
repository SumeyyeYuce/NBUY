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
    public class FoodCategoryConfig : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.HasKey(fc => new {fc.FoodId, fc.CategoryId});

            builder.ToTable("FoodCategory");

            builder.HasData(
                new FoodCategory { FoodId=1,  CategoryId=1}, 
                new FoodCategory { FoodId = 2, CategoryId = 1 },
                new FoodCategory { FoodId = 3, CategoryId = 1 },
                new FoodCategory { FoodId = 4, CategoryId = 1 }, 
                new FoodCategory { FoodId = 5, CategoryId = 1 },

                 new FoodCategory { FoodId = 6, CategoryId = 2 },
                 new FoodCategory { FoodId = 7, CategoryId = 2 } ,
                 new FoodCategory { FoodId = 7, CategoryId = 3 },
                 new FoodCategory { FoodId = 8, CategoryId = 3 },
                 new FoodCategory { FoodId = 9, CategoryId = 2 },
                 new FoodCategory { FoodId = 10, CategoryId = 3 },
                 new FoodCategory { FoodId = 10, CategoryId = 2 },

                new FoodCategory { FoodId = 11, CategoryId = 3 },
                new FoodCategory { FoodId = 12, CategoryId = 3 },
                new FoodCategory { FoodId = 12, CategoryId = 2}

                );
        }
    }
}
