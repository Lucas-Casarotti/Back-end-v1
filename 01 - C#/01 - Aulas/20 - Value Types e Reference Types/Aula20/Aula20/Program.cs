using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            // VALUE TYPES
            //int x = 10;
            //int y = x; // Y É UMA CÓPIA DE X
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //x = 20; // SOMENTE O X SERÁ ALTERADO, POIS O Y É APENAS UMA CÓPIA E NÃO UMA REFERÊNCIA DE X
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            // REFERENCE TYPES
            var arr = new string[2];
            arr[0] = "Item 1";
            var arr2 = arr; // NÃO CRIA UMA CÓPIA

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            // ALTERA AS DUAS LISTAS
            arr[0] = "Item alterado";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

        }
    }
}
