using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06
{
    internal class Carteira
    {
        private int Dinheiro = 50;
        public int MostrarSaldo(){
            return Dinheiro;
        }
        public void AcrescentarSaldo(int valor)
        {
            Dinheiro += valor;  
        }
    }
}
