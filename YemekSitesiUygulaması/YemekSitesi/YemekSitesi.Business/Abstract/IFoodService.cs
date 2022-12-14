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
        void Update(Food food);
        void Delete(Food food);
        List<Food> GetFoodsByCategory();
        Task<List<Food>> GetHomePageFoodsAsync();

    }
}
