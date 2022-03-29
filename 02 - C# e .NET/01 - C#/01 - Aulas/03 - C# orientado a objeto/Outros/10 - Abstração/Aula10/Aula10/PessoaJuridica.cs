using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class PessoaJuridica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para pessoa jurídica R$  :" + (valor * 0.2));
        }
    }
}
