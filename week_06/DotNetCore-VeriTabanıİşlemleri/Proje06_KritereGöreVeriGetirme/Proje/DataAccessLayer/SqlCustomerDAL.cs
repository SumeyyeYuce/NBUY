using System.Data.SqlClient;
using Proje.DataAccessLayer.Entities;
namespace Proje.DataAccessLayer
{
    public class SqlCustomerDAL : ICustomerDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString = @"Server=.\SQLEXPRESS; Database=Northwind; User=sa; Pwd=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
       
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT CustomerId,CompanyName,City,Country FROM Customers";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        customers.Add(new Customer()
                        {
                            Id = sqlDataReader[0].ToString(),
                            Company = sqlDataReader[1].ToString(),
                            City = sqlDataReader[2].ToString(),
                            Country = sqlDataReader[3].ToString()
                        });
                    }
                    sqlDataReader.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir sorun oluştu!");
                }
                finally
                {
                    connection.Close();
                }
            }
            return customers;
        }

        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}