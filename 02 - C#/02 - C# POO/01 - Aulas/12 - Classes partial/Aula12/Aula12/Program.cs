using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            p1.PropriedadeA = 1;
            p1.PropriedadeB = 1;

            Console.WriteLine(p1.PropriedadeA);
            Console.WriteLine(p1.PropriedadeB);
        }
    }
}
