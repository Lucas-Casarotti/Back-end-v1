using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Encapsulamento
{
    public class Produto
    {
        public string _nome;
        public double _preco;
        public int    _quantidade;

        public Produto(string nomeProduto, double precoProduto, int qtdProduto)
        {
            _nome       = nomeProduto;
            _preco      = precoProduto;
            _quantidade = qtdProduto;
        }

        public string GetNome()
        {
            return _nome;
        }
        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public void SetPreco(double preco)
        {
            _preco = preco;
        }
        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }


        public double ValorTotalEstoque()
        {
            return _quantidade * _preco;
        }

        // Vai ser do tipo void pois não vai retornar nada, apenas acrescentar
        public void AdicionarProdutos(int qtd)
        {
            _quantidade = _quantidade + qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            _quantidade = _quantidade - qtd;
        }

        public override string ToString()
        {
            return _nome
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}