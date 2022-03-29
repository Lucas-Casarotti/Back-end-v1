using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Retangulo
    {
        public double largura;
        public double altura;
        public double VL_Area;
        public double VL_Perimetro;
        public double VL_Diagonal;

        public void AreaRetangulo(double l, double a)
        {

            VL_Area = (l * a);
        }
        public void PerimetroRetangulo(double l, double a)
        {
            VL_Perimetro = ((2 * l) + (2 * a));
        }
        public void DiagonalRetangulo(double l, double a)
        {
            VL_Diagonal = ((l * a) / 2);
        }
    }
}
