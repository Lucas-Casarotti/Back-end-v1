using System;
using System.Globalization;

namespace CalculandoConsorcio
{
    class Program
    {
        static void Main(string[] args)
        {

            float valorbem        = 0;
            float prazo           = 0;
            float fundoreserva    = 0;
            float taxaADM         = 0;

            float Vfundocomum     = 0;
            float Vfundoreserva   = 0;
            float VtaxaADM        = 0;
            float VTotal          = 0;
            Console.WriteLine("---- CALCULANDO VALOR DA PARCELA DO CONSÓRCIO ----");

            Console.WriteLine("Digite o valor do bem: ");
            valorbem = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de meses a pagar: ");
            prazo = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantos % de fundo de reserva: ");
            fundoreserva = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantos % de taxa de administração: ");
            taxaADM = float.Parse(Console.ReadLine());


            Vfundocomum = ((100 / prazo) * valorbem);
            Vfundoreserva = (fundoreserva / prazo) * valorbem;
            VtaxaADM  = (taxaADM / prazo) * valorbem;

            VTotal = Vfundocomum + Vfundoreserva + VtaxaADM;
      
            Console.WriteLine("Valor do fundo comum:            " + Vfundocomum.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Valor do fundo reserva:          " + Vfundoreserva.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Valor da taxa de administração:  " + VtaxaADM.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Valor da taxa de administração:  " + VTotal.ToString("C", CultureInfo.CurrentCulture));
            /* 
             Valor do bem = R$ 100.000,00
             Prazo do grupo = 60 Meses
             Fundo de reserva = 3 %
             Taxa de administração = 18 %

             100 / 60 = 1,6667
             R$ 100.000,00 * 1,6667 = R$ 1.666,70 Valor do fundo comum

             3 % / 60 = 0,0005
             R$ 100.000,00 * 0,0005 = R$ 50,00 Valor do fundo reserva

             18 % / 60 = 0,3 %
              R$ 100.000,00 * 0,3 % = R$ 300,00 Valor da taxa de administração 
            */

        }
    }
}
