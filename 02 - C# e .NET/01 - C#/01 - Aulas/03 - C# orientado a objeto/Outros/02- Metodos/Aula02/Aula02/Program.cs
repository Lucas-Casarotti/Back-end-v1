using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();

            // UTILIZANDO MÉTODOS COM OS MESMOS NOMES, MAS COM PARAMETROS DIFERENTES
            obj.Apresentar();
            obj.Apresentar("Lucas");
            obj.Apresentar("Lucas", 22);
        }
    }
}
