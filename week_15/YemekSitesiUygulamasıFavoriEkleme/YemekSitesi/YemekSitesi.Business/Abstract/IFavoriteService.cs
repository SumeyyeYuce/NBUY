using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Business.Abstract
{
    public interface IFavoriteService
    {
        Task<Favorite> GetByIdAsync(int id);
        Task InitializeFavorite(string userId);
        Task AddToFavorite(string userId, int foodId, int favortiteNumber);
        Task<Favorite> GetFavByUserId(string userId);
    }
}
