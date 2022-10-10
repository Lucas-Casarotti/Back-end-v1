using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06
{
    public class Funcionarios : Pessoas
    {
        public decimal Salario;

        // CONSTRUCTOR
        public Funcionarios(string nome, int idade, decimal salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;

            MensagemPessoa();
            MensagemColaborador();
        }

        private void MensagemColaborador()
        {
            Console.WriteLine("Salario: " + Salario);
        }
    }
}
