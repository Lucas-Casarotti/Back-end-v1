using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA DE CONDIÇÃO SWITCH CASE
            string nome;
            Console.WriteLine("Digite um nome: ");
            nome = Console.ReadLine();

            switch (nome)
            {
                case "Lucas":
                    Console.WriteLine("Nome existente na base de dados");
                    break;
                case "José":
                    Console.WriteLine("Nome existente na base de dados");
                    break;
                default:
                    Console.WriteLine("Nome não encontrado na base de dados");
                    break;
            }
        }
    }
}
