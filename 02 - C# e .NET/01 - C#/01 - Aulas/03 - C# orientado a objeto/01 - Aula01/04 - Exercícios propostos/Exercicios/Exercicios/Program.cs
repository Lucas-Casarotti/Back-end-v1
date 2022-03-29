using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01 
            //Retangulo r = new Retangulo();
            //Console.Write("Digite a largura do retângulo: ");
            //r.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Digite a altura do retângulo: ");
            //r.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //r.AreaRetangulo(r.largura, r.altura);
            //r.PerimetroRetangulo(r.largura, r.altura);
            //r.DiagonalRetangulo(r.largura, r.altura);
            //Console.WriteLine("------------------------------------------------------------------");
            //Console.WriteLine("Área do retângulo: " + r.VL_Area);
            //Console.WriteLine("Perimetro do retângulo: " + r.VL_Perimetro );
            //Console.WriteLine("Diagonal retângulo: " + r.VL_Diagonal);

            //Exercício 02
            //Funcionario f = new Funcionario();
            //Console.WriteLine("------ Dados do funcionário ------");
            //Console.Write("Nome: ");
            //f.Nome = Console.ReadLine();
            //Console.Write("Salário bruto: ");
            //f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Imposto: ");
            //f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("---------------------------------------------------------------");
            //Console.WriteLine("Funcionário: " + f.Nome + ", R$ " + f.SalarioLiquido());
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------------------");
            //Console.WriteLine("Digite a porcentagem de aumento: ");
            //double Porcentagem = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //f.AumentoSalarial(Porcentagem);
            //Console.WriteLine("------ Dados do funcionário atualizado ------");
            //Console.WriteLine("Funcionário: " + f.Nome + ", R$ " + f.SalarioLiquido());


            //Exercício 03
            //Aluno aluno = new Aluno();
            //Console.WriteLine("------ Dados do aluno ------");
            //Console.Write("Nome: ");
            //aluno.Nome = Console.ReadLine();
            //Console.Write("RA: ");
            //aluno.RA = int.Parse(Console.ReadLine());
            //Console.Write("Primeira nota: ");
            //aluno.PrimeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Segunda nota: ");
            //aluno.SegundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Terceira nota: ");
            //aluno.TerceiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine(aluno.SituacaoAluno());


            //Exercicio 04
            //Mostrando a diferença de usar void
            Soma soma = new Soma();
            Console.WriteLine("Digite o primeiro número: ");
            soma.n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            soma.n2 = int.Parse(Console.ReadLine());

            //soma.ResultadoSoma(soma.n1, soma.n2);
            //Console.WriteLine("Resultado: " + soma.Resultado);
            Console.WriteLine("Resultado: " + soma.ResultadoSoma2());
        }
    }
}
