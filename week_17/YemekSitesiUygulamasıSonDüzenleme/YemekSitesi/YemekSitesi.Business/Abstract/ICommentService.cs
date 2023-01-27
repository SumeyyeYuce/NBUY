using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Business.Abstract
{
    public interface ICommentService
    {

        Task<Comment> GetByIdAsync(int id);
        Task CreateAsync(Comment comment); 
        void Update(Comment comment);
        void Delete(Comment comment);
        Task<List<Comment>> GetByFoodId(int foodId);
     
    }
}
