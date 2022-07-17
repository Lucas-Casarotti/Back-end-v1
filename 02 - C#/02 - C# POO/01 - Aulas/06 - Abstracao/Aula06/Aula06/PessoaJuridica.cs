using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06
{
    class PessoaJuridica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para pessoa jurídica R$  :" + (valor * 0.2));
        }
    }
}
