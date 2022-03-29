using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos
{
    class Calculadora
    {
        public double ValorPI = 3.14;

        
        public double Circunferencia(double raio)
        {
            return 2.0 * ValorPI * raio;
        }
        public double Volume(double raio)
        {
            return 4.0 / 3.0 * ValorPI * raio * raio * raio;
        }
    }
}
