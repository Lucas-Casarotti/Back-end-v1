using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;
            double resultado;
            Console.WriteLine("Digite três números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            resultado = NumeroMaior(n1, n2, n3);

            Console.WriteLine("Número maior: " + resultado);
        }

        static int NumeroMaior(int n1, int n2, int n3)
        {
            int maior;
            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }
            return maior;
        }
    }
}
