using Microsoft.Data.Sqlite;
using Proje.DataAccessLayer.Entities;
namespace Proje.DataAccessLayer
{
    public class SqliteProductDAL : IProductDAL
    {
        private SqliteConnection GetSqliteConnection()
        {
            string connectionString = "Data Source=northwind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            return sqliteConnection;
        }
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            using (var connection = GetSqliteConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products";
                    SqliteCommand sqliteCommand = new SqliteCommand(queryString, connection);
                    SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                    while (sqliteDataReader.Read())
                    {
                        products.Add(new Product()
                        {
                            Id = int.Parse(sqliteDataReader["ProductId"].ToString()),
                            Name = sqliteDataReader["ProductName"].ToString(),
                            Price = decimal.Parse(sqliteDataReader["UnitPrice"].ToString()),
                            Stock = int.Parse(sqliteDataReader["UnitsInStock"].ToString())
                        });
                    }
                    sqliteDataReader.Close();
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            throw new NotImplementedException();
        }
    }
}