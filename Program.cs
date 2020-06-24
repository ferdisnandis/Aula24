using System;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Welcome to night Vale",53.20f);
            Produto p2 = new Produto(2, "O circo mecânico Tresaulti", 33.99f);
            Produto p3 = new Produto (3, "1984", 40.40f);
            Produto p4 = new Produto (4, "Harry Potter e a pedra filosofal", 24.68f);

            //Adicionar os produtos ao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            //Mostrar carrinho
            carrinho.MostrarProdutos();
        }
    }
}
