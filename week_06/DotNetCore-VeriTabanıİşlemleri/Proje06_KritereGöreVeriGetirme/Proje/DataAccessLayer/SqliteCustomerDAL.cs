
using Microsoft.Data.Sqlite;
using Proje.DataAccessLayer.Entities;
namespace Proje.DataAccessLayer
{
    public class SqliteCustomerDAL : ICustomerDAL
    {
        private SqliteConnection GetSqliteConnection()
        {
            string connectionString = @"Data Source=northwind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            return sqliteConnection;
        }
       
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            using (var connection = GetSqliteConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT CustomerId,CompanyName,City,Country FROM Customers";
                    SqliteCommand sqliteCommand = new SqliteCommand(queryString, connection);
                    SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                    while (sqliteDataReader.Read())
                    {
                        customers.Add(new Customer()
                        {
                            Id = sqliteDataReader[0].ToString(),
                            Company = sqliteDataReader[1].ToString(),
                            City = sqliteDataReader[2].ToString(),
                            Country = sqliteDataReader[3].ToString()
                        });
                    }
                    sqliteDataReader.Close();
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