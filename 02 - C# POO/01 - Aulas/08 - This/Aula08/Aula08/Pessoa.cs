using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08
{
    internal class Pessoa
    {
        private string nome;

        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
    }
}
