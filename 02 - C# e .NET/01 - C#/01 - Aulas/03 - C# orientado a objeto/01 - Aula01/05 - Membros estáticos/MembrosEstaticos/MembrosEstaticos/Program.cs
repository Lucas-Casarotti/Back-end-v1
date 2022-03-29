using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        //static double ValorPI = 3.14;
        static void Main(string[] args)
        {   // Exemplo de membros estáticos
            // Membros estáticos, não precisam de objeto para serem chamados.
            //Calculadora calc = new Calculadora();
            //Console.WriteLine("Digite o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double circ = calc.Circunferencia(raio);
            //double volume = calc.Volume(raio);
            //Console.WriteLine("Circunferência: " + circ);
            //Console.WriteLine("Volume: " + volume);
            //Console.WriteLine("Valor de PI: " + calc.ValorPI);

            //Exercicio01
            ConversorDeMoeda moeda = new ConversorDeMoeda();
            Console.Write("Qual a cotação do dolar atual: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar: ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double vlReais = moeda.valorPagoEmReais(cotacao, qtdDolar);
            moeda.valorPagoEmReais(cotacao, qtdDolar);
            Console.Write("Valor a ser pago em reais: " + vlReais);

        }

        //Função para calcular a circunfêrencia
        //static double Circunferencia(double raio)
        //{
        //    return 2.0 * ValorPI * raio;
        //}
        //static double Volume(double raio)
        //{
        //    return 4.0 / 3.0 * ValorPI * raio * raio * raio;
        //}
    }
}
