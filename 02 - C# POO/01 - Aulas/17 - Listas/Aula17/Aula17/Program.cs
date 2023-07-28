using System;
using System.Collections.Generic;

namespace Aula17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var List = new List<Pessoa>();
            List.Add(new Pessoa("Lucas", 24));
            List.Add(new Pessoa("Matheus", 24));

            foreach(var Lista in List)
            {
                Console.WriteLine("Nome: " + Lista.nome + " Idade: " + Lista.idade);
            }

        }
    }
}
