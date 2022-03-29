using System;
using System.Globalization;

namespace ExerciciosResolvidos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01
            //int n1, i;
            //Console.WriteLine("Digite um número: ");
            //n1 = int.Parse(Console.ReadLine());

            //for (i = 1; i <=n1; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        Console.WriteLine("Números impares de 1 até " + n1 + " : " + i);
            //    }
            //}

            //Exercicio 02
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercicio 03
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{

            //    string[] line = Console.ReadLine().Split(' ');
            //    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            //    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
            //    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

            //    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}

            //Exercicio 04
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{

            //    string[] line = Console.ReadLine().Split(' ');
            //    int x = int.Parse(line[0]);
            //    int y = int.Parse(line[1]);

            //    if (y == 0)
            //    {
            //        Console.WriteLine("divisao impossivel");
            //    }
            //    else
            //    {
            //        double div = (double)x / y;
            //        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture);
            //    }
            //}

            //Exercicio 05
            //int n = int.Parse(Console.ReadLine());
            //int fat = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    fat = fat * i;
            //}
            //Console.WriteLine(fat);

            //Exercicio 06
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercicio 07
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{

            //    int primeiro = i;
            //    int segundo = i * i;
            //    int terceiro = i * i * i;
            //    Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            //}


            // Exercicios para fixar
            //int n, valor;
            //int soma = 0;
            //Console.WriteLine("Quantos números inteiros você vai digitar? ");
            //n = int.Parse(Console.ReadLine());
            //for (int i = 1; i<=n; i++)
            //{
            //    Console.WriteLine("Digite o valor: #{0} ", i);
            //    valor = int.Parse(Console.ReadLine());

            //    soma = soma + valor;
            //}
            //Console.WriteLine("Resultado da soma dos números: " + soma);
            int qtd = 0;
            int numero = 0;
            Console.WriteLine("Verificador de números pares");
            Console.WriteLine("Quantos números você irá verificar? ");
            qtd = int.Parse(Console.ReadLine());

            for(int i=0; i < qtd; i++)
            {
                Console.WriteLine("Digite o número: ");
                numero = int.Parse(Console.ReadLine());

                if(numero % 2 == 0)
                {
                    Console.WriteLine("Número " + numero + " é par ");
                }else
                {
                    Console.WriteLine("Número " + numero + " é impar ");
                }
            }
        }
    }
}
