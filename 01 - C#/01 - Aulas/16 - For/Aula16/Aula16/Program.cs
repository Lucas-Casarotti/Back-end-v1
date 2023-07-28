using System;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA DE REPETIÇÃO FOR 
            // CONTANDO DE 0 ATÉ 5
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            // CONTANDO DE 5 ATÉ 0
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            
            int qtd;
            Console.WriteLine("Digite até que número deseja ser imprimido: ");
            qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i <= qtd; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
