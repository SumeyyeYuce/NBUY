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
    public class EfCoreFavoriteRepository : EfCoreGenericRepository<Favorite>, IFavoriteRepository
    {
        public EfCoreFavoriteRepository(YemekSitesiContext context) : base(context)
        {

        }

        private YemekSitesiContext YemekSitesiContext
        {
            get { return _context as YemekSitesiContext; }
        }

        public async Task AddToFavorite(string userId, int foodId, int favortiteNumber)
        {
            var favorite = await GetFavByUserId(userId);
            if (favorite != null)
            {
                var index = favorite.FavoriteItems.FindIndex(fi => fi.FoodId == foodId);

                if (index<0)
                {
                    favorite.FavoriteItems.Add(new FavoriteItem
                    {
                        FoodId = foodId,    
                        FavoriteId= favorite.Id,
                        FavortiteNumber = favortiteNumber   
                    });
                }
                else
                {
                    favorite.FavoriteItems[index].FavortiteNumber += favortiteNumber;
                }
                YemekSitesiContext.Favorites.Update(favorite);
            }
        }

        public async Task<Favorite> GetFavByUserId(string userId)
        {
            var favorite = await YemekSitesiContext
                .Favorites
                .Include(f => f.FavoriteItems)
                .ThenInclude(fi => fi.Food)
                .FirstOrDefaultAsync(f => f.UserId == userId);
            return favorite;
        }
    }
}
