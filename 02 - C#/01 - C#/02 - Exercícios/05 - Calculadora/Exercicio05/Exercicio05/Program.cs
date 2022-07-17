using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-------------- Calculadora --------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.Write("Escolha uma opção: ");
            opc = int.Parse(Console.ReadLine());

            if(opc == 1)
            {
                soma();
            }else if (opc == 2)
            {
                subtracao();
            }else if(opc == 3)
            {
                divisao();
            }else
            {
                multiplicacao();
            }


        }

        static void soma ()
        {
            float n1, n2, resultado;
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = float.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine("Resultado: " + resultado);

        }
        static void subtracao()
        {
            float n1, n2, resultado;
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = float.Parse(Console.ReadLine());
            resultado = n1 - n2;
            Console.WriteLine("Resultado: " + resultado);

        }
        static void divisao()
        {
            float n1, n2, resultado;
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = float.Parse(Console.ReadLine());
            resultado = (n1/n2);
            Console.WriteLine("Resultado: " + resultado);

        }
        static void multiplicacao()
        {
            float n1, n2, resultado;
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = float.Parse(Console.ReadLine());
            resultado = n1 * n2;
            Console.WriteLine("Resultado: " + resultado);

        }
    }
}
