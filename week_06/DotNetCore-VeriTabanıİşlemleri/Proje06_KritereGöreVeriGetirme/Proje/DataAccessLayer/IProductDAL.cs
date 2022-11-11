using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Proje.DataAccessLayer.Entities;

namespace Proje.DataAccessLayer
{
    public interface IProductDAL
    {
        void Create(Product product);    // C-reate
        List<Product> GetAll();         // R-ead
        Product GetById(int id);
        void Update(Product product);    // U-pdate
        void Delete(int id);             // D-elete
        List<Product> GetProductsByCategory(string categoryName);
         
        List<Product> GetProductsByCategoryId(int id);
    }
}