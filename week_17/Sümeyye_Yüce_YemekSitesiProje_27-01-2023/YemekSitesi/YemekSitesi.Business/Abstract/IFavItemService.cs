using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Business.Abstract
{
    public interface IFavItemService
    {
        Task<FavoriteItem> GetByIdAsync(int id);
        void Delete(FavoriteItem favoriteItem);
    }
}
