using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05
{
    internal class Pessoa
    {
        public string Nome;
        public Pessoa()
        {
            Console.WriteLine("Construtor executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }
    }
}
