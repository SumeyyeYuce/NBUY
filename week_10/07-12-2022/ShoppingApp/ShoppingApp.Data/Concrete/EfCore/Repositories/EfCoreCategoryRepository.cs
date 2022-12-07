using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopAppContext context):base(context) //burdaki base miras aldıgım EfCoreGenericRepository dan burdan geliyor(shopAppContexti base gönderdik)
        {
            //buraya gelen context base calsa göderilşiuor ve aynı zamdna bu ctro içinde geçerli ama bu clasın bütünüde henüz kullamılamıyor
            //eger kullanılmak istemilse yapılması gererekn işlemler var
        }
        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
    }
}
