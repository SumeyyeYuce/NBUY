using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public interface ICustomersDAL
    {
         void CreateCustomers(Customers customers);   //C-reate
        List<Customers> GetAllCustomers();        //R-ead
        Customers GetByIdCustomers(int id);
        void UpdateCustomers(Customers customers);    //U-pdate 
        void DeleteCustomers(int id);             //D-elete

     
    }
}