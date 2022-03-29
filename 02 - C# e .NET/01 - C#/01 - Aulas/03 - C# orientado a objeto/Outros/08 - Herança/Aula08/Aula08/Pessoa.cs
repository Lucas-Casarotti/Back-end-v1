using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    class Pessoa
    {
        protected string nome;
        protected int idade;


        protected void mensagemPessoa()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
        }
    }
}
