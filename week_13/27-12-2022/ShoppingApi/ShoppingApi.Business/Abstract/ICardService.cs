using ShoppingApi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Business.Abstract
{
    public interface ICardService
    {
        Task<Card> GetByIdAsync(int id);
        Task InitializeCard(string userId);
        Task AddToCard(string userId, int productId, int quantity);
        Task<Card> GetCardByUserId(string userId);
      

    }
}
