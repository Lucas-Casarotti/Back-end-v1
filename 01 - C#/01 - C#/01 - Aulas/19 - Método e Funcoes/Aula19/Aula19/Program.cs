using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            // FUNÇÃO / MÉTODO
            // FUNÇÃO 01
            //int n1, n2;
            //int total;
            //Console.WriteLine("Digite o primeiro número: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número: ");
            //n2 = int.Parse(Console.ReadLine());

            //total = CalculaNumeros(n1, n2);
            //Console.WriteLine("Resultado da soma: " + total);

            // FUNÇÃO 02
            int n1, n2, n3, resultado;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());

            resultado = CalculaNumeros(n1, n2, n3);
            Console.WriteLine("Número maior: " + resultado);
        }

        //static int CalculaNumeros(int n1, int n2)
        //{
        //    return n1 + n2;
        //}
        static int CalculaNumeros(int n1, int n2, int n3)
        {
            int maior;
            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }else if ( n2 > n1 && n2 > n3)
            {
                maior = n2;
            }else
            {
                maior = n3;
            }
            return maior;
        }
    }
}
