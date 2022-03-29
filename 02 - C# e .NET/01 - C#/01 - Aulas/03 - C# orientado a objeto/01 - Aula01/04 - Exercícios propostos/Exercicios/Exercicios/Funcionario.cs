using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
           return SalarioBruto - Imposto;
        }
        public void AumentoSalarial(double Porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * Porcentagem / 100.00);
        }
    }
}
