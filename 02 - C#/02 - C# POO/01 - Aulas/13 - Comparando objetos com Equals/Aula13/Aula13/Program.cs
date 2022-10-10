using System;

namespace Aula13
{
    class Program
    {
        // EQUALS
        static void Main(string[] args)
        {
            var pessoa1 = new Pessoa();
            var pessoa2 = new Pessoa();

            pessoa1.NM_Pessoa = "Teste";
            pessoa2.NM_Pessoa = "Teste";

            Console.WriteLine(pessoa1.Equals(pessoa2));
        }

        
    }
}
