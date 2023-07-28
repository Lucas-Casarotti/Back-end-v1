using System;

namespace Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.SetNome("Lucas");
            Console.WriteLine(pessoa.GetNome());

        }
    }
}
