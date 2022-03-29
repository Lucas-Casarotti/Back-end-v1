using System;
using System.Globalization;

namespace PalavraThis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digita os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            Console.WriteLine("Dados do produto: " +p);
        }
    }
}
