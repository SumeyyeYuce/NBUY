using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
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