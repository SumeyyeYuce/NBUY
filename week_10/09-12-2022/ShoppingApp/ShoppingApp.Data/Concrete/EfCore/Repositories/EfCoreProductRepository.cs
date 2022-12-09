using Microsoft.EntityFrameworkCore;
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
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopAppContext context):base(context)
        {

        }
        private ShopAppContext ShopAppContext
        {
            get { return _context as ShopAppContext;  }
        }
                
        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await ShopAppContext
                .Products
                .Where(p => p.IsHome && p.IsApproved)
                .ToListAsync();
        }

        public Task<Product> GetProductDetailsByUrlAsync(string productUrl)
        {
            //product bilgisni getir getirken de vategory ilgini getir
            return ShopAppContext
                .Products
                .Where(p => p.Url == productUrl)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
           var products=  ShopAppContext.Products.AsQueryable();//var olan productları getricek
            if (category!=null)
            {
                products =  products
                    .Where(p => p.IsApproved)
                    .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                    .Where(p => p.ProductCategories.Any(pc => pc.Category.Url == category));
                    
            }
            return await products.ToListAsync();
               

        }

        public async Task<List<Product>> GetProductsWithCategories()
        {

            return await ShopAppContext//shopApp den product sa eriş
                .Products
                .Include(p => p.ProductCategories)//productların içinde dön Include ile proudct bilgilerini dahil et(yani her p nin productCategoriesine geç)
                .ThenInclude(pc => pc.Category)//birinnci üürndeyken productCategroisdnen category bilgisni al demiş oluyotux
                .ToListAsync();
        }
    }
}
