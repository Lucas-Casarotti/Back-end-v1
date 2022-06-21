using System;
using System.Collections.Generic;
using System.Text;

namespace Aula07
{
    class Atendente : Imposto
    {
        // MÉTODO override = sobrescrevendo um método
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto atendente do vale alimentação R$ " + (salario * 0.12));
        }
    }
}
