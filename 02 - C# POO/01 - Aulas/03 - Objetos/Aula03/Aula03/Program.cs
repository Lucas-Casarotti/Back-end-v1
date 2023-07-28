using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Cal = new Calculadora();

            Cal.n1 = 1;
            Cal.n2 = 2;

            // COM MÉTODO VOID
            Cal.adcao(Cal.n1, Cal.n2);
            Console.WriteLine("Total: " + Cal.total);

            // COM MÉTODO RETURN
            Console.WriteLine("Total: " + Cal.adcao2());
        }
    }
}
