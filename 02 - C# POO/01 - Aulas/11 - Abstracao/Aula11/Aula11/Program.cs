using System;

namespace Aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            Gato gato = new Gato();

            cachorro.Som();
            gato.Som();
        }
    }
}
