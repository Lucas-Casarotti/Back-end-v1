using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03
{
    public class Calculadora
    {
        public int n1;
        public int n2;
        public int total;

        public void adcao(int n1, int n2)
        {
            total = n1 + n2;
        }

        public int adcao2()
        {
            return n1 + n2;
        }
    }
}
