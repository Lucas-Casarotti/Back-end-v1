using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09
{
    class Imposto
    {
        // MÉTODO DO TIPO VIRTUAL PODE SER SOBRESCRITO NA CLASSE HERDEIRA
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
