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
    public class EfCoreFoodRepository : EfCoreGenericRepository<Food>, IFoodRepository
    {
        public EfCoreFoodRepository(YemekSitesiContext context):base(context)
        {

        }
        private YemekSitesiContext YemekSitesiContext
        {
            get { return _context as YemekSitesiContext; }

        }
        public List<Food> GetFoodsByCategory()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Food>> GetHomePageFoodsAsync()
        {
            return await YemekSitesiContext
                 .Foods
                 .Where(f => f.IsHome)
                 .ToListAsync();
        }
    }
}
