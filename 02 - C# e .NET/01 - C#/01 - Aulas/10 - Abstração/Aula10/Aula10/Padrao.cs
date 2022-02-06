using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    abstract class Padrao
    {
        // MÉTODO OBRIGATÓRIO
        public abstract void taxaEmprestimo(double valor);
       

        // MÉTODO OPCIONAL
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança  R$: " + (valor * taxa));
        }
    }
}
