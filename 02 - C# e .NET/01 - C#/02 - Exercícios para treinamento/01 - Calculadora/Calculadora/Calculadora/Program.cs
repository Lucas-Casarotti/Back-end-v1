using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n1, n2, resultado = 0;
            string operacao;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação: 1- Soma 2- Subtração 3- Multiplicação 4- Divisão");
            operacao = Console.ReadLine();

            
            switch (operacao)
            {
                case "1":
                    resultado = n1 + n2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case "2":
                    resultado = n1 - n2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case "3":
                    resultado = n1 * n2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case "4":
                    resultado = n1 / n2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;

            }
            
        }
    }
}
