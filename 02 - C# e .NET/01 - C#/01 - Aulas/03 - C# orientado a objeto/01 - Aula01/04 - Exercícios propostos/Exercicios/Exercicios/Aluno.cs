using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Aluno
    {
        public string Nome;
        public int RA;
        public double PrimeiraNota;
        public double SegundaNota;
        public double TerceiraNota;


        public string SituacaoAluno()
        {
            double TotalNotas = PrimeiraNota + SegundaNota + TerceiraNota;

            if (TotalNotas >= 60)
            {
                return "Parabéns você foi aprovado!" 
                       + "com " + TotalNotas + " pontos";
            }
            else
            {
                double restante = 90 - TotalNotas;
                return "Infelizmente você foi reprovado!"
                      + "faltou " + restante + " pontos";
            }
        }
    }
}
