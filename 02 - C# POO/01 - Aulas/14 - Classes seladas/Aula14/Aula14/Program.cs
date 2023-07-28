using System;

namespace Aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public sealed class Pessoa
    {
        public int idade;
        public string nome;
    }
    public class Funcionario : Pessoa
    {

    }
}
