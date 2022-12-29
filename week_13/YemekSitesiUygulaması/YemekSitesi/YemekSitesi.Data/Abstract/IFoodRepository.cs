using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Data.Abstract
{
    public interface IFoodRepository :IRepository<Food>
    {
        List<Food> GetFoodsByCategory();//Kategoriye göre food getirmeisni saglicak
        Task<List<Food>> GetHomePageFoodsAsync();//anasayfa ürünlerini getiricek

    }
}
