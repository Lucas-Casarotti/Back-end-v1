using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01 
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

            //Pessoa p1, p2;
            //p1 = new Pessoa();
            //p2 = new Pessoa();
            //Console.WriteLine("Digite o nome da primeira pessoa: ");
            //p1.NomePessoa = Console.ReadLine();
            //Console.WriteLine("Digite a idade da primeira pessoa: ");
            //p1.IdadePessoa = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o nome da segunda pessoa: ");
            //p2.NomePessoa = Console.ReadLine();
            //Console.WriteLine("Digite a idade da segunda pessoa: ");
            //p2.IdadePessoa = int.Parse(Console.ReadLine());

            //FuncaoVerificaIdade(p1, p2);


            //Exercício 02
            //Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            //médio dos funcionários.

            //Funcionario f1, f2;
            //f1 = new Funcionario();
            //f2 = new Funcionario();
            //Console.WriteLine("Digite o nome do primeiro funcinário: ");
            //f1.NomeFuncionario = Console.ReadLine();
            //Console.WriteLine("Digite o salário do primeiro funcinário: ");
            //f1.SalarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Digite o nome do segundo funcinário: ");
            //f2.NomeFuncionario = Console.ReadLine();
            //Console.WriteLine("Digite o salário do segundo funcinário: ");
            //f2.SalarioFuncionario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //SalarioMedio(f1, f2);

        }

        //static void FuncaoVerificaIdade(Pessoa p1, Pessoa p2)
        //{
        //    if (p1.IdadePessoa > p2.IdadePessoa)
        //    {
        //        Console.WriteLine(p1.NomePessoa + " é mais velha(o) que " + p2.NomePessoa);
        //    }
        //    else
        //    {
        //        Console.WriteLine(p2.NomePessoa + " é mais velha(o) que " + p1.NomePessoa);
        //    }
        //}

        //static void SalarioMedio(Funcionario f1, Funcionario f2)
        //{
        //    double SalarioMedio;
        //    SalarioMedio = (f1.SalarioFuncionario + f2.SalarioFuncionario) / 2.0;
        //    Console.WriteLine("Salário médio: " + SalarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        //}
    }
}
