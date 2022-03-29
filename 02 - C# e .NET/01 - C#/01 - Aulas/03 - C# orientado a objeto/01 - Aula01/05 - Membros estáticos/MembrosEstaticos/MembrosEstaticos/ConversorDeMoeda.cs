using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos
{
    class ConversorDeMoeda
    {
        
        public double valorPagoEmReais(double cotacao, double qtdDolar)
        {
            return cotacao * qtdDolar;
        }
    }
}
