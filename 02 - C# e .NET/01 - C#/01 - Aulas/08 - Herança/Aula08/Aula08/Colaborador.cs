using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    class Colaborador : Pessoa
    {
        private double salario;

        // CONSTRUCTOR
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome       = nome;
            this.idade      = idade;
            this.salario    = salario;

            mensagemPessoa();
            mensagemColaborador();
        }


        // MÉTODO
        private void mensagemColaborador()
        {
            Console.WriteLine("Salário: " + salario);
        }
    }
}
