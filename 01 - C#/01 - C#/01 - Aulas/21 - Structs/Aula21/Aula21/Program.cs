using System;

namespace Aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIANDO A ESTRUTURA
            Product Bolacha = new Product(1, "Passa tempo", 10, 3.50);

            Console.WriteLine(Bolacha.ID_Produto);
            Console.WriteLine(Bolacha.NM_Produto);
            Console.WriteLine(Bolacha.QTD_Produto);
            Console.WriteLine(Bolacha.VL_Produto);
        }
    }

    // STRUCT
    struct Product
    {  // MÉTODO CONSTRUTOR
        public Product(int id, string nome, int qtd, double valor)
        {
            ID_Produto = id;
            NM_Produto = nome;
            QTD_Produto = qtd;
            VL_Produto = valor;
        }
        // ATRIBUTOS
        public int ID_Produto;
        public string NM_Produto;
        public int QTD_Produto;
        public double VL_Produto;
        // MÉTODOS
        public double ValorEmDolar(double VL_Dolar)
        {
            return VL_Produto * VL_Dolar;
        }
    }
}
