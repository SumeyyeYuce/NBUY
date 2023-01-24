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
    public class EfCoreCommentRepository : EfCoreGenericRepository<Comment>, ICommentRepository 
    {
        public EfCoreCommentRepository(YemekSitesiContext context) : base(context)
        {
        }

        public Comment GetByIdWithFoods()
        {
            throw new NotImplementedException();
        }
    }
}
