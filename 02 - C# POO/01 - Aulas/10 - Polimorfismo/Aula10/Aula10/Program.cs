using System;

namespace Aula10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de Polimorfismo de Sobrecarga
            //Calculadora Cal = new Calculadora();

            //Console.WriteLine(Cal.Somar(10, 50));
            //Console.WriteLine(Cal.Somar(10.5, 50));

            // Exemplo de Polimorfismo de Sobreposição


            Cachorro cachorro = new Cachorro();
            cachorro.Som();
        }
    }
}
