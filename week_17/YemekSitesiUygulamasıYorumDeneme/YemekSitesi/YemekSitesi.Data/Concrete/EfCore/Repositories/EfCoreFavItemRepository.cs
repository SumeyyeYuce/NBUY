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
    public class EfCoreFavItemRepository : EfCoreGenericRepository<FavoriteItem>, IFavItemRepository
    {
        public EfCoreFavItemRepository(YemekSitesiContext context) : base(context)
        {

        }
    }
}
