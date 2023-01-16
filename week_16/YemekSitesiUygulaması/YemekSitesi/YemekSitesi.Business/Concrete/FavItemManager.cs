using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Data.Abstract;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Business.Concrete
{

    public class FavItemManager : IFavItemService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FavItemManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Delete(FavoriteItem favoriteItem)
        {
            _unitOfWork.FavItems.Delete(favoriteItem);
            _unitOfWork.Save();
        }

        public async Task<FavoriteItem> GetByIdAsync(int id)
        {
            return await _unitOfWork.FavItems.GetByIdAsync(id); 
        }
    }
}
