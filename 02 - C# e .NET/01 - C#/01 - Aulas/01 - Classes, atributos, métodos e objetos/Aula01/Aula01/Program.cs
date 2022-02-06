using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIANDO UM OBJETO DO TIPO PESSOA
            Pessoa obj = new Pessoa();

            obj.NomePessoa  = "Lucas";
            obj.IdadePessoa = 22;
            // EXECUTANDO UMA AÇÃO
            obj.Mensagem();
        }
    }
}
