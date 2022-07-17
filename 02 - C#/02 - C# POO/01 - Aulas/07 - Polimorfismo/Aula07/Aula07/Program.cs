using System;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto objG = new Gerente();
            objG.valeAlimentacao(5000);
            objG.valeTransporte(5000);
            Console.WriteLine("------------------------------------------------");
            
            Imposto objA = new Atendente();
            objA.valeAlimentacao(2000);
            objA.valeTransporte(2000);
            Console.WriteLine("------------------------------------------------");
        }
    }
}
