using System.Data.SqlClient;

namespace Proje04_VeriErisimSinifi;
class Program
{
    static void Main(string[] args)
    {   int secim;
        do
        {
            Console.Clear();
            Console.WriteLine("1-Product List");
            Console.WriteLine("2-Customer List");
            Console.WriteLine("0-Exit");
            Console.WriteLine("Litfen seçimi girin");
            secim = int.Parse(Console.ReadLine());
        if (secim==1)
        {
             ProductList();
             Console.ReadLine();
        }
        else if (secim==2)
        {
            //CustomerList();
             Console.ReadLine();
           
        }
        else if (secim!=0)
        {
            Console.WriteLine("geçerli bir seçim yapın");
        }
        
        } while (secim!=0);
     
    }
    static void ProductList()
    {
        var sqlProductDAL=new SqlProductDAL();
         List<Product> products = sqlProductDAL.GetAllProducts();
        // var sqliteProductDAL = new SqliteProductDAL();
        // List<Product> products = sqliteProductDAL.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"Id:{product.Id}, Name:{product.Name}, Price:{product.Price}, Stock:{product.Stock}");
        }
    }

    // static void  CustomerList()
    // {
    //        List<Customers> cumtomers = GetAllCustomers();
    //     foreach (var customer in cumtomers)
    //     {
    //         Console.WriteLine($"Id:{customer.Id}, Name:{customer.Name}, City:{customer.City}, Country:{customer.Country}");
    //     }
    // }

   
    // static List<Customers> GetAllCustomers()
    // {
    //      List<Customers> customers = new List<Customers>();
    //     using (var connection=GetSqlConnection())
    //     {
    //         try
    //         {
    //             connection.Open();
    //             string queryString="SELECT CustomerID,CompanyName,City,Country FROM Customers";
    //             SqlCommand sqlCommand = new SqlCommand(queryString,connection);
    //             SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
    //             while (sqlDataReader.Read())
    //             {
    //                customers.Add(new Customers(){
    //                     Id=sqlDataReader["CustomerID"].ToString(),
    //                     Name=sqlDataReader["CompanyName"].ToString(),
    //                     City=sqlDataReader["City"].ToString(),
    //                     Country=sqlDataReader["Country"].ToString()

    //                });
    //             }
    //             sqlDataReader.Close();
    //         }
    //         catch (Exception)
    //         {
    //             Console.WriteLine("Bir sorun oluştu");
                
    //         }
    //         finally
    //         {
    //             connection.Close();
    //         }
    //     }
    //     return customers;
    // }


    
}
