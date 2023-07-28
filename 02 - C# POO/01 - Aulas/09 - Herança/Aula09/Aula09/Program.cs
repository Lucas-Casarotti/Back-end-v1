using System;

namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();

            fun.Nome = "Lucas";
            fun.Idade = 24;

            Console.WriteLine(fun.Dados());
        }
    }
}
