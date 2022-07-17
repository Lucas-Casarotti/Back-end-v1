using System;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=DESKTOP-3KK17LJ\\SQLEXPRESS;Initial Catalog=Estudo;Integrated Security=True;Encrypt=False";
            
            using(var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Conectado");
                connection.Open();

                using(var command = new SqlCommand())
                {
                    command.Connection  = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT NM_Pessoa FROM Pessoas";


                    var reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader.GetString(1)}");
                    }
                }
            }
           
        }
    }
}
