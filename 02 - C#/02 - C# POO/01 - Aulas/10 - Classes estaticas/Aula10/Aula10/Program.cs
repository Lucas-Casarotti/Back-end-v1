using System;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexao.StringConexao = "teste";
            Console.WriteLine(Conexao.StringConexao);
        }
    }
    // CLASSE ESTÁTICA 
    public static class Conexao
    {
        public static string StringConexao;
    }
}
