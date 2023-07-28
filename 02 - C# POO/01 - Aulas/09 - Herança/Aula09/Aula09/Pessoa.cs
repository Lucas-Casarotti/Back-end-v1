using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Dados()
        {
            return "Nome: " + Nome + " Idade: " + Idade;
        }
    }
}
