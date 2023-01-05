using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Data.Abstract;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Business.Concrete
{
    public class FoodManager : IFoodService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FoodManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Food food)
        {
           await _unitOfWork.Foods.CreateAsync(food);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<Food>> GetAllAsync()
        {
            return await _unitOfWork.Foods.GetAllAsync();
        }

        public async Task<Food> GetByIdAsync(int id)
        {
           return await _unitOfWork.Foods.GetByIdAsync(id);
        }

        public void Delete(Food food)
        {
           _unitOfWork.Foods.Delete(food);
            _unitOfWork.Save();
        }

        public void Update(Food food)
        {
            _unitOfWork.Foods.Update(food);
            _unitOfWork.Save();
        }

        public async Task<List<Food>> GetFoodsByCategoryAsync(string category)
        {
            return await _unitOfWork.Foods.GetFoodsByCategoryAsync(category);
        }

        public async Task<List<Food>> GetHomePageFoodsAsync()
        {
           return await _unitOfWork.Foods.GetHomePageFoodsAsync();
        }

        public async Task<Food> GetFoodDetailsByUrlAsync(string foodUrl)
        {
            return await _unitOfWork.Foods.GetFoodDetailsByUrlAsync(foodUrl);

        }

        public async Task<List<Food>> GetFoodsWithCategories()
        {
            return await _unitOfWork.Foods.GetFoodsWithCategories(); 
        }

        public async Task CreateFoodAsync(Food food, int[] selectedCategoryIds)
        {
            await _unitOfWork.Foods.CreateFoodAsync(food, selectedCategoryIds);
        }

        public async Task UpdateFoodAsync(Food food, int[] selectedCategoryIds)
        {
            await _unitOfWork.Foods.UpdateFoodAsync(food, selectedCategoryIds);
        }

        public async Task<Food> GetFoodWithCategories(int id)
        {
            return await _unitOfWork.Foods.GetFoodWithCategories(id);
        }

        public async Task UpdateIsHomeAsync(Food food)
        {
            await _unitOfWork.Foods.UpdateIsHomeAsync(food);
        }

        public async Task UpdateIsApprovedAsync(Food food)
        {
            await _unitOfWork.Foods.UpdateIsApprovedAsync(food);
        }
    }
}
