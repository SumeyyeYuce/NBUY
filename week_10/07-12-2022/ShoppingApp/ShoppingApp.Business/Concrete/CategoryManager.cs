using ShoppingApp.Business.Abstract;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Generic

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _unitOfWork.Categories.GetByIdAsync(id);//_unitOfWork deki Categories deki GetByIdAsync bu id yi çalıştır
        }
        public async Task<List<Category>> GetAllAsync()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }
        public async Task CreateAsync(Category category)
        {
           await _unitOfWork.Categories.CreateAsync(category);// _unitOfWork böyle diyerek efRepository olan herşeye erişebiliyoruz
           await _unitOfWork.SaveAsync();
        }

        public void Delete(Category category)
        {
            _unitOfWork.Categories.Delete(category);  //kategori kaydını sil
            _unitOfWork.Save();                                        
        }
    
        public void Update(Category category)
        {
            _unitOfWork.Categories.Update(category);    
            _unitOfWork.Save();
        }
        #endregion

        #region Categories
        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
        #endregion



    }
}
