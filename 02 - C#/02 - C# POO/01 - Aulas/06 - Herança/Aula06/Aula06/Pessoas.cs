using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06
{
    public class Pessoas
    {
        protected string Nome;
        protected int Idade;

        protected void MensagemPessoa()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
    }
}
