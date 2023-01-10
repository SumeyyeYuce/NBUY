using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Business.Abstract
{
    public interface IFoodService
    {
        Task<Food> GetByIdAsync(int id);
        Task<List<Food>> GetAllAsync();
        Task CreateAsync(Food food);
        Task CreateFoodAsync(Food food, int[] selectedCategoryIds);
        void Update(Food food);
        Task UpdateFoodAsync(Food food, int[] selectedCategoryIds);
        void Delete(Food food);
        Task<List<Food>> GetFoodsByCategoryAsync(string category);
        Task<List<Food>> GetHomePageFoodsAsync();
        Task<Food> GetFoodDetailsByUrlAsync(string foodUrl);
        Task<List<Food>> GetFoodsWithCategories();
        Task<Food> GetFoodWithCategories(int id);
        Task UpdateIsHomeAsync(Food food);
        Task UpdateIsApprovedAsync(Food food);

    }
}
