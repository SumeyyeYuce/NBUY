using System.Data.SqlClient;

namespace Proje02_VerilerinCekilmesi;
class Program
{
    static void Main(string[] args)
    {
        GetSqlConnection();
    }

    static void GetSqlConnection()
    {
        string connectionString = @"Server=DESKTOP-OFVK2FD; Database=Northwind; User=sa; Pwd=123";
        using (var connection= new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Baglantı saglandı");
                string queryString = "SELECT * FROM Products";
                SqlCommand sqlCommand = new SqlCommand(queryString,connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int sayac=1;
               
               while (sqlDataReader.Read())
               {
                    Console.WriteLine($"Sıra:{sayac} -Name:{sqlDataReader[1]} - Price:{sqlDataReader[5]}");
                    sayac++;
               }
               sqlDataReader.Close();
            }
            catch (Exception e)
            {
                
               Console.WriteLine(e.Message);
               
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
