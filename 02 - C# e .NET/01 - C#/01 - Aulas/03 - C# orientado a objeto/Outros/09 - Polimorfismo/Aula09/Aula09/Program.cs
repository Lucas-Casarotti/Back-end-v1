using System;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //obj vai ter acesso aos métodos da classe Imposto, e se a classe tiver algum método
            // valeAlimentação ou valeRefeição ele vai sobreescrever o método que esta em Imposto

            //INSTANCIAR GERENTE
            Imposto objG = new Gerente();
            objG.valeAlimentacao(5000);
            objG.valeTransporte(5000);
            Console.WriteLine("------------------------------------------------");
            //INSTANCIAR ATENDENTE 
            Imposto objA = new Atendente();
            objA.valeAlimentacao(2000);
            objA.valeTransporte(2000);
            Console.WriteLine("------------------------------------------------");
            // INSTANCIAR ESTAGIÁRIO
            Imposto objE = new Estagiario();
            objE.valeAlimentacao(1000);
            objE.valeTransporte(1000);
            Console.WriteLine("------------------------------------------------");
        }
    }
}
