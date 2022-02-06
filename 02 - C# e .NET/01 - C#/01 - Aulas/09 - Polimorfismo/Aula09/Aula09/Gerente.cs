using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    class Gerente : Imposto
    {
        // override = sobrescrevendo um método
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto gerente do vale alimentação R$ " + (salario * 0.15));
        }
    }
}
