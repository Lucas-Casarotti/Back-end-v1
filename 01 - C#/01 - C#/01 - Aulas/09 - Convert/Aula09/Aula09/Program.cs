using System;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONVERT
            // UTILIZANDO O CONVERT TOSTRING
            //int ValorInteiro1 = 100;
            //int ValorInteiro2 = 100;
            // ATRIBUINDO UM VALOR INTEIRO A UMA VARIÁVEL DO TIPO STRING
            // ERRADO
            //string valor = ValorInteiro1;
            // CERTO
            //string valor2 = Convert.ToString(ValorInteiro2);

            // UTILIZANDO O CONVERT TOINT
            string ValorInteiro1 = "100";
            string ValorInteiro2 = "100";
            // ATRIBUINDO UMA STRING A UMA VARIÁVEL DO TIPO INT
            // ERRADO
            int valor = ValorInteiro1;
            //CERTO
            int valor2 = Convert.ToInt32(ValorInteiro2);
        }
    }
}
