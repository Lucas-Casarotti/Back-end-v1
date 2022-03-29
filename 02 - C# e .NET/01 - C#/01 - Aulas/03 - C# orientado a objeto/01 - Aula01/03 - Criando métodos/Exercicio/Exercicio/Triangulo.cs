using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    public class Triangulo
    {
        // Public deixa os atributos acessíveis para outros arquivos
        public double A;
        public double B;
        public double C;

        // Criando um método
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

}
