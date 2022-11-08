﻿using System.Data.SqlClient;

namespace P01_SqlBaglantiOlusturma;
class Program
{
    static void Main(string[] args)
    {
        GetSqlConnection();
        
    }
    static void GetSqlConnection()
    {
        /*1.Adım
            connectionstring oluşturmak
        */
        string connectionString = @"Server=DESKTOP-OFVK2FD; Database=Northwind; User Id=sa; Password=123";
        using (var connection = new SqlConnection(connectionString))
        {
            //connection nesnesi
            try
            {
                connection.Open();
                Console.WriteLine("Baglantı saglandı..");
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
        // var connection=new SqlConnection(connectionString);
        // connection.Open();
       

    }
}
