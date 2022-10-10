using System;
using System.Collections.Generic;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            // LISTAS 
            var Listas = new List<Pessoa>();
            Listas.Add(new Pessoa(1, "Lucas"));
            Listas.Add(new Pessoa(2, "Pedro"));
            Listas.Add(new Pessoa(2, "Vitor"));

            foreach(var Lista in Listas)
            {
                Console.WriteLine("Código: " + Lista.CD_Pessoa + " Nome: " + Lista.NM_Pessoa);
            }

        }
    }
}
