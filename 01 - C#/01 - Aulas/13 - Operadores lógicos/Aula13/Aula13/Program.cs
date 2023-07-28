using System;

namespace Aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            // OPERADORES LÓGICOS 
            // AND - OBRIGA TODAS AS CONDIÇÕES SEREM VERDADEIRAS   &&
            // OR  - SE ATENDER UMA CONDIÇÃO JÁ RETORNA VERDADEIRO ||
            // NOT - NEGAÇÃO                                       !
            int x = 12;
            bool entre = (x > 25) && (x < 40); // FALSE
            bool ou = (x > 25) || (x < 40);    // TRUE
            bool negacao = !(x < 25);         // FALSE

        }
    }
}
