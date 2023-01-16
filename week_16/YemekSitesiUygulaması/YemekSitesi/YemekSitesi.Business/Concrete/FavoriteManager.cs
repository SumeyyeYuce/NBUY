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
    public class FavoriteManager : IFavoriteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FavoriteManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddToFavorite(string userId, int foodId, int favortiteNumber)
        {
           
            await _unitOfWork.Favorites.AddToFavorite(userId,foodId, favortiteNumber);
            await _unitOfWork.SaveAsync();  

        }

        public async Task<Favorite> GetByIdAsync(int id)
        {
            return await _unitOfWork.Favorites.GetByIdAsync(id);
        }

        public async Task<Favorite> GetFavByUserId(string userId)
        {
            return await _unitOfWork.Favorites.GetFavByUserId(userId);
        }

        public async Task InitializeFavorite(string userId)
        {
            await _unitOfWork.Favorites.CreateAsync(new Favorite { UserId = userId });
            await _unitOfWork.SaveAsync();
        }
    }
}
