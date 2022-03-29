using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIANDO O OBJETO
            Pessoa p = new Pessoa();
            p.peso = 80;
            p.altura = 1.80;

            p.mensagem();
        }
    }
}
