using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Funcionario
    {
        public string NomeFuncionario;
        public string CargoFuncionario;
        public double SalarioFuncionario;

        public void SalarioComBonus(double bonus)
        {
            SalarioFuncionario = SalarioFuncionario + bonus;
        }
        
    }
}
