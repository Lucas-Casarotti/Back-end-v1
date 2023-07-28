using System;

namespace Aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + Calculadora.Soma(n1, n2));
        }
    }
}
