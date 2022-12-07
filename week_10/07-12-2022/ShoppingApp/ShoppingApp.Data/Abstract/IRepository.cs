using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);//id ye göre entity getiricek (get)
        Task<List<T>> GetAllAsync();//ilgili entity ile ilgili tüm kayıtları getiricek
        Task CreateAsync(T entity);//yeni kayıt yaratır
        void Update(T entity);//kayıt günveller
        void Delete(T entity);//kayıt siler

    }
}
