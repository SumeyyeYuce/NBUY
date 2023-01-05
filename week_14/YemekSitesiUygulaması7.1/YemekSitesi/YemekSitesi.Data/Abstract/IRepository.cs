using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSitesi.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);//id ye göre entity getiricek (get)
        Task<List<T>> GetAllAsync();// entity ile ilgili tüm kayıtları getiricek
        Task CreateAsync(T entity);//yeni kayıt oluşturucak
        void Update(T entity);//kayıt güncellicek
        void Delete(T entity); //Silicek

    }
}
