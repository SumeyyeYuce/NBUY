using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IProductRepository :IRepository<Product>
    {
        //product özgü memberlar burada olucak

        //örnegğin aşşagıdaki gibi
        List<Product> GetProductsByCategory();//Kategoriye göre product getirmeisni saglicak
        Task<List<Product>> GetHomePageProductsAsync();//Ansayfa üürnlerini getirsin
    }
}
