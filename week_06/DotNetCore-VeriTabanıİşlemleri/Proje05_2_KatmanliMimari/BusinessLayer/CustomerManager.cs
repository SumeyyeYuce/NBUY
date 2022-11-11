using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanliMimari.DataAccessLayer;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.BusinessLayer
{
    public class CustomerManager
    {
        private readonly ICustomerDAL _customerDAL;
        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }
        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            
            return _customerDAL.GetAll();
            
        }

        public Customer GetByIdCustomer(int id)
        {
            throw new NotImplementedException();
        }

       

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}