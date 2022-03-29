using System;
using System.Collections.Generic;
using System.Text;

namespace PalavraThis
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            //Nome = nome;
            //Preco = preco;
            //Quantidade = quantidade;

            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

        }

        public override string ToString()
        {
            return this.Nome + ", R$ " + this.Preco + ", unidades: " + this.Quantidade;
        }
    }
}
