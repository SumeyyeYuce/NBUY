using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Data.Abstract
{
    public interface IFavoriteRepository :IRepository<Favorite>
    {
        Task AddToFavorite(string userId, int foodId, int favortiteNumber);
        Task<Favorite> GetFavByUserId(string userId);
    }
}
