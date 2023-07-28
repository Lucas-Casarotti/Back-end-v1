using System;
using DataAccess.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=DESKTOP-3KK17LJ\\SQLEXPRESS;Initial Catalog=TESTEDAPPER;Integrated Security=True;Encrypt=False";

            using (var connection = new SqlConnection(connectionString))
            {

                ListarPessoas(connection);
                AdicionarPessoas(connection);
                AlterarPessoas(connection);
            }

        }

        static void ListarPessoas(SqlConnection connection)
        {

            var Pessoa = connection.Query<Pessoa>("SELECT ID_Pessoa AS idPessoa, NM_Pessoa AS nmPessoa FROM dbo.Pessoas");
            foreach(var p in Pessoa)
            {
                Console.WriteLine($"{p.idPessoa} - {p.nmPessoa}");
            }
        }

        static void AdicionarPessoas(SqlConnection connection)
        {
            var p1 = new Pessoa();
            p1.nmPessoa = "Jotinha";

            var insertPessoa = @"INSERT INTO dbo.Pessoas VALUES(@nmPessoa)";

            connection.Execute(insertPessoa, new
            {
                p1.nmPessoa
            });
        }

        static void AlterarPessoas(SqlConnection connection)
        {
            var p1 = new Pessoa();
            p1.idPessoa = 1;
            p1.nmPessoa = "Jotinha";

            var updatePessoa = @"UPDATE dbo.Pessoas SET NM_Pessoa = @nmPessoa 
                                 WHERE ID_Pessoa = @idPessoa";

            connection.Execute(updatePessoa, new
            {
                p1.idPessoa,
                p1.nmPessoa
            });
        }
    }
}
