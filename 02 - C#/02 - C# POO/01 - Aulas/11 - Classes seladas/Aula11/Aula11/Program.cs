using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    // CLASSES SELADAS
    public sealed class Pessoas {
        public int ID_Pessoa;
        public string NM_Pessoa;
    }
    // CLASSE DO TIPO PESSOA NÃO PODE SER HERDADA, POIS É UMA CLASSE DO TIPO SELADA
    public class Funcionario : Pessoas
    {

    }
}
