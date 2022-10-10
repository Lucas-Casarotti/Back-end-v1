using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIANDO UM OBJETO
            Pessoas p1 = new Pessoas();
            p1.ID_Pessoa = 1;
            p1.NM_Pessoa = "Lucas";
            Console.WriteLine("Código pessoa:" + p1.ID_Pessoa);
            Console.WriteLine("Nome pessoa:" + p1.NM_Pessoa);
        }
    }
}
