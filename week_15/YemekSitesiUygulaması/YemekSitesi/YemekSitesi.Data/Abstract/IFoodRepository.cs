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
        Task<List<Food>> GetFoodsByCategoryAsync(string category);//Kategoriye göre food getirmeisni saglicak
        Task<List<Food>> GetHomePageFoodsAsync();//anasayfa ürünlerini getiricek
        Task<Food> GetFoodDetailsByUrlAsync(string foodUrl);
        Task<List<Food>> GetFoodsWithCategories();
        Task CreateFoodAsync(Food food, int[] selectedCategoryIds);
        Task<Food> GetFoodWithCategories(int id);
        Task UpdateFoodAsync(Food food, int[] selectedCategoryIds);
        Task UpdateIsHomeAsync(Food food);
        Task UpdateIsApprovedAsync(Food food);
    }
}
