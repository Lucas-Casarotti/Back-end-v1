﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicios
{
    public class Produto
    {
        public string NomeProduto;
        public double PrecoProduto;
        public int QtdProduto;


        public double ValorTotalEstoque()
        {
            return QtdProduto * PrecoProduto;
        }

        // Vai ser do tipo void pois não vai retornar nada, apenas acrescentar
        public void AdicionarProdutos(int qtd)
        {
            QtdProduto = QtdProduto + qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            QtdProduto = QtdProduto - qtd;
        }

        public override string ToString()
        {
            return NomeProduto
                + ", R$ "
                + PrecoProduto.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + QtdProduto
                + " unidades, Total R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
