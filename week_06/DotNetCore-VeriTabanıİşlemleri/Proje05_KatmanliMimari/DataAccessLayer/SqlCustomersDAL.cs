using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public class SqlCustomersDAL : ICustomersDAL
    {

         private SqlConnection GetSqlConnection()
        {
            string connectionString = @"Server=DESKTOP-OFVK2FD; Database=Northwind; User=sa; Pwd=123";
            SqlConnection  sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        
        }
        public void CreateCustomers(Customers customers)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomers(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAllCustomers()
        {
             List<Customers> customers = new List<Customers>();
        using (var connection=GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString="SELECT CustomerID,CompanyName,City,Country FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(queryString,connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                   customers.Add(new Customers(){
                        Id=sqlDataReader["CustomerID"].ToString(),
                        Name=sqlDataReader["CompanyName"].ToString(),
                        City=sqlDataReader["City"].ToString(),
                        Country=sqlDataReader["Country"].ToString()

                   });
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Bir sorun oluştu");
                
            }
            finally
            {
                connection.Close();
            }
        }
        return customers;
        }

        public Customers GetByIdCustomers(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomers(Customers customers)
        {
            throw new NotImplementedException();
        }
    }
}