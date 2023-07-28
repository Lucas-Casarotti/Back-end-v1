using System;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carteira carteira = new Carteira();

            Console.WriteLine("Informe a opcao: 1 - Mostrar saldo 2 - Acrescentar saldo");
            int opc = int.Parse(Console.ReadLine());

            if (opc == 1)
            {
                Console.WriteLine("Saldo atual: " + carteira.Dinheiro);
            }
            else
            {
                Console.WriteLine("Digite o saldo a acrescentar: ");
                int valor = int.Parse(Console.ReadLine());
                carteira.Dinheiro = valor;
                Console.WriteLine("Saldo atual: " + carteira.Dinheiro);
            }
        }
    }
}
