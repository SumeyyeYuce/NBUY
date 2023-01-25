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
        Task<List<Food>> GetFoodsByCategoryAsync(string category);
        Task<List<Food>> GetHomePageFoodsAsync();
        Task<Food> GetFoodDetailsByUrlAsync(string foodUrl);
        Task<List<Food>> GetFoodsWithCategories();
        Task CreateFoodAsync(Food food, int[] selectedCategoryIds);
        Task<Food> GetFoodWithCategories(int id);
        Task UpdateFoodAsync(Food food, int[] selectedCategoryIds);
        Task UpdateIsHomeAsync(Food food);
        Task UpdateIsApprovedAsync(Food food);
        Task<List<Food>> GetSearchResultsAsync(string searchString, bool isApproved = true);
    }
}
