using System;
using System.Collections.Generic;
using System.Text;

namespace Aula07
{
    internal class Carteira
    {
        private int Dinhero_Saldo = 50;

        public int Dinheiro
        {
            get { return Dinhero_Saldo; }
            set { Dinhero_Saldo += value;}
        }
    }
}
