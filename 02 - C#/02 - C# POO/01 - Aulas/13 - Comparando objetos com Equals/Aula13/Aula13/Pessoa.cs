using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Aula13
{
    class Pessoa
    {
        public string NM_Pessoa;
        public bool Equals(Pessoa pessoa)
        {
            return NM_Pessoa == pessoa.NM_Pessoa;
        }
    }
}
