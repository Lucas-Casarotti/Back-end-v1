using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nome;
            int idade;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Nome: " + idade);

        }
    }
}
