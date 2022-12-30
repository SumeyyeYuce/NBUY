using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Data.Abstract;
using YemekSitesi.Data.Concrete.EfCore.Contexts;
using YemekSitesi.Data.Concrete.EfCore.Repositories;

namespace YemekSitesi.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly YemekSitesiContext _context;

        public UnitOfWork(YemekSitesiContext context)
        {
            _context = context;
        }

        private EfCoreFoodRepository _foodRepository;
        private EfCoreCategoryRepository _categoryRepository;



        public IFoodRepository Foods => _foodRepository = _foodRepository ?? new EfCoreFoodRepository(_context);

     public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);   
        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
