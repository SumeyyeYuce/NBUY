using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Data.Abstract;
using YemekSitesi.Data.Concrete.EfCore.Contexts;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Data.Concrete.EfCore.Repositories
{
    public class EfCoreFoodRepository : EfCoreGenericRepository<Food>, IFoodRepository
    {
        public EfCoreFoodRepository(YemekSitesiContext context):base(context)
        {

        }
        private YemekSitesiContext YemekSitesiContext
        {
            get { return _context as YemekSitesiContext; }

        }

        public async Task CreateFoodAsync(Food food, int[] selectedCategoryIds)
        {
            await YemekSitesiContext.Foods.AddAsync(food);
            await YemekSitesiContext.SaveChangesAsync();
            food.FoodCategories = selectedCategoryIds
                .Select(ctId => new FoodCategory
                {

                    FoodId = food.Id,
                    CategoryId = ctId
                }).ToList();
            await YemekSitesiContext.SaveChangesAsync();

        }

        public Task<Food> GetFoodDetailsByUrlAsync(string foodUrl)
        {
            return YemekSitesiContext
                .Foods
                .Where(f => f.Url == foodUrl)
                .Include(f => f.FoodCategories)
                .ThenInclude(fc => fc.Category)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Food>> GetFoodsByCategoryAsync(string category)
        {
            var foods = YemekSitesiContext.Foods.AsQueryable();
            if (category != null)
            {
                foods = foods
                    .Where(f => f.IsApproved)
                    .Include(f => f.FoodCategories)
                    .ThenInclude(fc => fc.Category)
                    .Where(f => f.FoodCategories.Any(fc => fc.Category.Url == category));

            }
            return await foods.ToListAsync();

        }

        public async Task<List<Food>> GetFoodsWithCategories()
        {
            return await YemekSitesiContext
                .Foods
                .Include(f => f.FoodCategories)
                .ThenInclude(fc => fc.Category)
                .ToListAsync();
        }

        public async Task<Food> GetFoodWithCategories(int id)
        {
            return await YemekSitesiContext
                 .Foods
                 .Where(f => f.Id == id)
                 .Include(f => f.FoodCategories)
                 .ThenInclude(fc => fc.Category)
                 .FirstOrDefaultAsync();
        }

        public async Task<List<Food>> GetHomePageFoodsAsync()
        {
            return await YemekSitesiContext
                 .Foods
                 .Where(f => f.IsHome && f.IsApproved)
                 .ToListAsync();
        }

        public async Task UpdateFoodAsync(Food food, int[] selectedCategoryIds)
        {
            Food newFood = await YemekSitesiContext
                .Foods
                .Include(f => f.FoodCategories)
                .FirstOrDefaultAsync(f => f.Id == food.Id);

            newFood.FoodCategories = selectedCategoryIds
              .Select(ctId => new FoodCategory
              {
                  FoodId = newFood.Id,
                  CategoryId = ctId
              }).ToList();

            YemekSitesiContext.Update(newFood);
            await YemekSitesiContext.SaveChangesAsync();

        }

        public async Task UpdateIsApprovedAsync(Food food)
        {
            food.IsApproved = !food.IsApproved;
            YemekSitesiContext.Update(food);
            await YemekSitesiContext.SaveChangesAsync();
        }

        public async Task UpdateIsHomeAsync(Food food)
        {
            food.IsHome = !food.IsHome;
            YemekSitesiContext.Update(food);
            await YemekSitesiContext.SaveChangesAsync();
        }
    }
}
