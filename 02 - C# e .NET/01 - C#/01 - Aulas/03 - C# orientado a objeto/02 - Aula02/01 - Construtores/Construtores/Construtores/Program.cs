using Construtores;
using System;
using System.Globalization;
namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01 
            

            Console.WriteLine("Digita os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Passando os parametros do construtor
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("------------------------------------");
            //Console.WriteLine("Dados do produto: " + p.NomeProduto + ", R$ " + p.PrecoProduto + p.QtdProduto + " unidades, Total: R$ " + p.ValorTotalEstoque());
            //Console.WriteLine("Dados do produto: " +p);

            Console.WriteLine("Escolha uma operação 1 - Adicionar produto no estoque 2 - Remover produto do estoque 3 - Sair");
            int opc = int.Parse(Console.ReadLine());

            while (opc != 3)
            {
                int qtd = 0;
                if (opc == 1)
                {
                    Console.WriteLine("Digite a quantidade: ");
                    qtd = int.Parse(Console.ReadLine());
                    p.AdicionarProdutos(qtd);
                }
                else
                {
                    Console.WriteLine("Digite a quantidade: ");
                    qtd = int.Parse(Console.ReadLine());
                    p.RemoverProdutos(qtd);
                }
                Console.WriteLine("Escolha uma operação 1 - Adicionar produto no estoque 2 - Remover produto do estoque 3 - Sair");
                opc = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
