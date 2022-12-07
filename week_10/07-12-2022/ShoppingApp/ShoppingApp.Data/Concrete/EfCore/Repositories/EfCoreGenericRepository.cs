using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : class,
        new()
    {
        protected readonly DbContext _context;

        public EfCoreGenericRepository(DbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);//bu artık contex.product ve dışarıdan gelen entity
        }

        public  void Delete(TEntity entity)
        {
             _context.Set<TEntity>().Remove(entity);//dışarıdan gelen etity yi sil
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
          return  await _context.Set<TEntity>().ToListAsync();//GERİYE ASENKRON OLARAK TÜM KAYITLARI GETİRİCEK
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);//FindAsync(id); buraya ne göndeirsen o tablonu primary keyini arar
        }

        public void Update(TEntity entity)
        {
             _context.Set<TEntity>().Update(entity);
            //_context.Entry(entity).State=EntityState.Modified; bu şekilde de yapabilriz
        }
    }
}
