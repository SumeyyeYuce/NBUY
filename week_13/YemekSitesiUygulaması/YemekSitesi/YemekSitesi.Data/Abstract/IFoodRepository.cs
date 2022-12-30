﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Data.Abstract
{
    public interface IFoodRepository :IRepository<Food>
    {
        Task<List<Food>> GetFoodsByCategoryAsync(string category);//Kategoriye göre food getirmeisni saglicak
        Task<List<Food>> GetHomePageFoodsAsync();//anasayfa ürünlerini getiricek
        Task<Food> GetFoodDetailsByUrlAsync(string foodUrl);
    }
}
