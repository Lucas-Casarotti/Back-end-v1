using System;
using System.Globalization;
namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01 
            //Produto p = new Produto();

            //Console.WriteLine("Digita os dados do produto");
            //Console.Write("Nome: " );
            //p.NomeProduto = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.PrecoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade: ");
            //p.QtdProduto = int.Parse(Console.ReadLine());


            //Console.WriteLine("------------------------------------");
            ////Console.WriteLine("Dados do produto: " + p.NomeProduto + ", R$ " + p.PrecoProduto + p.QtdProduto + " unidades, Total: R$ " + p.ValorTotalEstoque());
            ////Console.WriteLine("Dados do produto: " +p);

            //Console.WriteLine("Escolha uma operação 1 - Adicionar produto no estoque 2 - Remover produto do estoque 3 - Sair");
            //int opc = int.Parse(Console.ReadLine());

            //while (opc != 3)
            //{
            //    int qtd = 0;
            //    if (opc == 1)
            //    {
            //        Console.WriteLine("Digite a quantidade: ");
            //        qtd = int.Parse(Console.ReadLine());
            //        p.AdicionarProdutos(qtd);
            //    } 
            //    else
            //    {
            //        Console.WriteLine("Digite a quantidade: ");
            //        qtd = int.Parse(Console.ReadLine());
            //        p.RemoverProdutos(qtd);
            //    }
            //    Console.WriteLine("Escolha uma operação 1 - Adicionar produto no estoque 2 - Remover produto do estoque 3 - Sair");
            //    opc = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Dados do produto: " + p);


            //Exercício 02
            //Faça um programa em que é digitado o nome, cargo e salário de um funcionário. Caso esse funcionário bater a meta ele irá receber um bônus
            Funcionario f = new Funcionario();
            Console.Write("Digite o nome do funcionário: ");
            f.NomeFuncionario = Console.ReadLine();
            Console.Write("Digite o cargo do funcionário: ");
            f.CargoFuncionario = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            f.SalarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Funcionário bateu a meta? 1- Sim  2 - Não");
            int opc = int.Parse(Console.ReadLine());
            if (opc == 1)
            {
                Console.WriteLine("Digite o bonus de salário recebido: ");
                double bonus = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f.SalarioComBonus(bonus);
            }else
            {
                Console.WriteLine("Infelizmente você não irá receber bonus");
            }
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Holerite mensal");
            Console.WriteLine("Nome:   " + f.NomeFuncionario);
            Console.WriteLine("Cargo:   " + f.CargoFuncionario);
            Console.WriteLine("Salário: " + f.SalarioFuncionario);
        }
    }
}
