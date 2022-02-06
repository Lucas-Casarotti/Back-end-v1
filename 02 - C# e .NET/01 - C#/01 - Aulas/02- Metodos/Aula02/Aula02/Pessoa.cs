using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    class Pessoa
    {
        // METODO 01 
        public void Apresentar()
        {
            Console.WriteLine("Olá, mundo");
        }

        // METODO 02 
        public void Apresentar(string nome)
        {
            Console.WriteLine("Olá, " + nome);
        }

        //METODO 03
        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Olá, " + nome + " você tem " + idade + " anos");
        }

    }
}
