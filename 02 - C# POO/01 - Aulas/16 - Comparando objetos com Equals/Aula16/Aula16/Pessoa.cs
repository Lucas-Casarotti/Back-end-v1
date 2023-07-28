using System;
using System.Collections.Generic;
using System.Text;

namespace Aula16
{
    internal class Pessoa
    {
        public string nome;

        public bool Equals(Pessoa pessoa)
        {
            return nome == pessoa.nome;
        }
    }
}
