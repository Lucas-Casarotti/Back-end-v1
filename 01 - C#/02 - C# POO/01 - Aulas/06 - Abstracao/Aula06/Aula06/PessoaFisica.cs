using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06
{
    class PessoaFisica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para pessoa física R$  :" + (valor * 0.1));
        }
    }
}
