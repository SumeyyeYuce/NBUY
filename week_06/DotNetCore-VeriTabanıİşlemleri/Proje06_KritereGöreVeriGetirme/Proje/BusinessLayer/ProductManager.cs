using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje.DataAccessLayer;
using Proje.DataAccessLayer.Entities;

namespace Proje.BusinessLayer
{
    public class ProductManager
    {
        private readonly IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            // return sqliteProductDAL.GetAllProducts();
            return _productDAL.GetAll();
            
        }

        public Product GetByIdProduct(int id)
        {
            return _productDAL.GetById(id);
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            return _productDAL.GetProductsByCategory(categoryName);
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            return _productDAL.GetProductsByCategoryId(id);
        }
    }
}