using System;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
	        // CONVERSÃO IMPLÍCITA 
	        // COMO OS DOIS SÃO DO TIPO NÚMERICO NÃO A NECESSIDADE DE REALIZAR A CONVERSÃO
            double valor = 25.8f;
            int outro = 25;
            valor = outro;
        }
    }
}
