using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSitesi.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        //Task<List<T>> GetByFoodId(int foodId);
        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
