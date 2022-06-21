using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIANDO UM OBJETO
            Calculadora cal = new Calculadora();
            Console.WriteLine("Digite o primeiro número inteiro: ");
            // PASSANDO VALORES PARA OS ATRIBUTOS
            cal.n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro: ");
            cal.n2 = int.Parse(Console.ReadLine());

            // MÉTODO
            cal.Soma(cal.n1, cal.n2);
            Console.WriteLine("Soma dos dois números inteiros: " + cal.total);
        }
    }
}
