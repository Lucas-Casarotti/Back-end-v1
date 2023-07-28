using System;

namespace Aula16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();   
            Pessoa p2 = new Pessoa();

            p1.nome = "Lucas";
            p2.nome = "Lucas";

            Console.WriteLine(p1.Equals(p2));
        }
    }
}
