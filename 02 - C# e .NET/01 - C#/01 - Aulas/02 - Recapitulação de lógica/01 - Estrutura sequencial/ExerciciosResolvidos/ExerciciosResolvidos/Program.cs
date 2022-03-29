using System;
using System.Globalization;

namespace ExerciciosResolvidos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01
            //int n1, n2, soma;

            //Console.WriteLine("Digite o primeiro valor: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //n2 = int.Parse(Console.ReadLine());

            //soma = n1 + n2;
            //Console.WriteLine("Resultado: " + soma);

            //----------------------------------------------------------//
            //Exercicio02
            //double R, A, pi = 3.14159;
            //Console.WriteLine("Digite o valor do raio: ");
            //R = int.Parse(Console.ReadLine());

            //A = pi * R * R;
            //Console.WriteLine("Resultado: " + A);

            //----------------------------------------------------------//
            //Exercicio03
            //int A, B, C, D, dif;

            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());

            //dif = A * B - C * D;
            //Console.WriteLine("DIFERENÇA = " + dif);

            //----------------------------------------------------------//
            //Exercicio04

            //int numero, horas;
            //double valorHora, salario;

            //numero = int.Parse(Console.ReadLine());
            //horas = int.Parse(Console.ReadLine());
            //valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salario = valorHora * horas;

            //Console.WriteLine("NUMBER = " + numero);
            //Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            //----------------------------------------------------------//
            //Exercicio05
            //int cod1, cod2, qte1, qte2;
            //double preco1, preco2, total;

            //string[] valores = Console.ReadLine().Split(' ');
            //cod1 = int.Parse(valores[0]);
            //qte1 = int.Parse(valores[1]);
            //preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //valores = Console.ReadLine().Split(' ');
            //cod2 = int.Parse(valores[0]);
            //qte2 = int.Parse(valores[1]);
            //preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //total = preco1 * qte1 + preco2 * qte2;

            //Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


            //----------------------------------------------------------//
            //Exercicio06
            //double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            //string[] valores = Console.ReadLine().Split(' ');
            //A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //triangulo = A * C / 2.0;
            //circulo = 3.14159 * C * C;
            //trapezio = (A + B) / 2.0 * C;
            //quadrado = B * B;
            //retangulo = A * B;

            //Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
