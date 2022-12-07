using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Abstract
{
    //kategorilele ilgili tüm metotlar olsun
    //buraya hem generic metotları hmede kategoriRepositordeki metotların yazılması lazım
    public interface ICategoryService
    {
        Task<Category> GetByIdAsync(int id);
        Task<List<Category>> GetAllAsync();
        Task CreateAsync(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetByIdWithProducts();
    }
}
