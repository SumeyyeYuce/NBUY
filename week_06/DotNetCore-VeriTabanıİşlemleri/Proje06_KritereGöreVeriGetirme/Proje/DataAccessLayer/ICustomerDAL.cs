using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Proje.DataAccessLayer.Entities;

namespace Proje.DataAccessLayer
{
    public interface ICustomerDAL
    {
        void Create(Customer customer);    // C-reate
        List<Customer> GetAll();         // R-ead
        Customer GetById(int id);
        void Update(Customer customer);    // U-pdate
        void Delete(int id);             // D-elete
    
    }
}