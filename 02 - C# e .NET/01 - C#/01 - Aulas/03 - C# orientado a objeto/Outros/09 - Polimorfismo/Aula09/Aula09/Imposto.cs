using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    class Imposto
    {
        // virtual = o valor dentro do método poderá ser alterado
        public virtual void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto padrão do vale alimentação R$ " + (salario * 0.1));

        }

        public void valeTransporte(double salario)
        {
            Console.WriteLine("Desconto padrão do vale transporte R$ " + (salario * 0.06));

        }
    }
}
