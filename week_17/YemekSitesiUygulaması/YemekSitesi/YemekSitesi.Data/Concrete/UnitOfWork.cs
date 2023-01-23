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
        private EfCoreFavoriteRepository _favoriteRepository;
        private EfCoreFavItemRepository _favItemRepository;

        public IFoodRepository Foods => _foodRepository = _foodRepository ?? new EfCoreFoodRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);

        public IFavoriteRepository Favorites => _favoriteRepository = _favoriteRepository ?? new EfCoreFavoriteRepository(_context);

        public IFavItemRepository FavItems => _favItemRepository = _favItemRepository ?? new EfCoreFavItemRepository(_context); 

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
