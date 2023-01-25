using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Data.Abstract
{
    public interface ICommentRepository:IRepository<Comment>
    {
        Comment GetByIdWithFoods();
        Task<List<Comment>> GetByFoodId(int foodId);
    }
}
