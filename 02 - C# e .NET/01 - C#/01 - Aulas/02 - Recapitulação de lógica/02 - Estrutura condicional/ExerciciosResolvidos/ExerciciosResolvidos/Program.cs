using System;
using System.Globalization;

namespace ExerciciosResolvidos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01
            //int n1;
            //Console.WriteLine("Digite um número: ");
            //n1 = int.Parse(Console.ReadLine());
            //if(n1 < 0 )
            //{
            //    Console.WriteLine("Número negativo");
            //}else
            //{
            //    Console.WriteLine("Número positivo");
            //}

            //Exercicio 02
            //int n1;
            //Console.WriteLine("Digite um número: ");
            //n1 = int.Parse(Console.ReadLine());
            //if(n1 % 2 == 0)
            //{
            //    Console.WriteLine("Número par");
            //}else
            //{
            //    Console.WriteLine("Número ímpar");
            //}

            //Exercicio 03
            //int A, B;
            //Console.WriteLine("Digite o primeiro valor: ");
            //A = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //B = int.Parse(Console.ReadLine());
            //if(A % B == 0 || B % A == 0)  
            //{
            //    Console.WriteLine("Números multiplos");
            //}else
            //{
            //    Console.WriteLine("Número não são multiplos");
            //}

            //Exercicio 04
            //int HI, HF;
            //Console.WriteLine("Digite o inicio do game: ");
            //HI = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o final do game: ");
            //HF = int.Parse(Console.ReadLine());
            //int duracao;
            //if (HI < HF)
            //{
            //    duracao = HF - HI;
            //}
            //else
            //{
            //    duracao = 24 - HI + HF;
            //}
            //Console.WriteLine("O jogo durou " + duracao + " Hora(s)");

            //Exercicio 05
            //int pedido, qtd;
            //double total;
            //Console.WriteLine("Digite o número do seu pedido: ");
            //Console.WriteLine(" 1 - Cachorro quente R$ 17.00");
            //Console.WriteLine(" 2 - X tudo          R$ 22.00");
            //Console.WriteLine(" 3 - X burguer       R$ 19.00");
            //Console.WriteLine(" 4 - X salada        R$ 18.00");
            //Console.WriteLine(" 5 - X frango        R$ 20.00");
            //pedido = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quandidade: ");
            //qtd = int.Parse(Console.ReadLine());

            //if (pedido == 1)
            //{
            //    total = 17 * qtd;
            //    Console.WriteLine("Valor total R$" +total);
            //}
            //else if(pedido == 2)
            //{
            //    total = 22 * qtd;
            //    Console.WriteLine("Valor total R$" + total);
            //}
            //else if (pedido == 3)
            //{
            //    total = 19 * qtd;
            //    Console.WriteLine("Valor total R$" + total);
            //}
            //else if (pedido == 4)
            //{
            //    total = 18 * qtd;
            //    Console.WriteLine("Valor total R$" + total);
            //}
            //else if (pedido == 5)
            //{
            //    total = 20 * qtd;
            //    Console.WriteLine("Valor total R$" + total);
            //}

            //Exercicio 06
            //double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (numero < 0.0 || numero > 100.0)
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}
            //else if (numero <= 25.0)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (numero <= 50.0)
            //{
            //    Console.WriteLine("Intervalo (25,50]");
            //}
            //else if (numero <= 75.0)
            //{
            //    Console.WriteLine("Intervalo (50,75]");
            //}
            //else
            //{
            //    Console.WriteLine("Intervalo (75,100]");
            //}

            //Exercicio 07
            //string[] valores = Console.ReadLine().Split(' ');
            //double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            //if (x == 0.0 && y == 0.0)
            //{
            //    Console.WriteLine("Origem");
            //}
            //else if (x == 0.0)
            //{
            //    Console.WriteLine("Eixo Y");
            //}
            //else if (y == 0.0)
            //{
            //    Console.WriteLine("Eixo X");
            //}
            //else if (x > 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if (x < 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if (x < 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q3");
            //}
            //else
            //{
            //    Console.WriteLine("Q4");
            //}

            //Exercicio 08 
            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double imposto;
            //if (salario <= 2000.0)
            //{
            //    imposto = 0.0;
            //}
            //else if (salario <= 3000.0)
            //{
            //    imposto = (salario - 2000.0) * 0.08;
            //}
            //else if (salario <= 4500.0)
            //{
            //    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            //}
            //else
            //{
            //    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            //}

            //if (imposto == 0.0)
            //{
            //    Console.WriteLine("Isento");
            //}
            //else
            //{
            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            //}


        }
    }
}
