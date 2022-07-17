using System;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA CONDIÇÃO IF E ELSE
            int idade;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else {
                Console.WriteLine("Você é menor de idade");
            }

        }
    }
}
