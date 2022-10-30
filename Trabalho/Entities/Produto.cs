using System;
using System.Collections.Generic;


namespace Trabalho.Entities
{
    internal class Produto : Estoque
    {
        public int CodProduct { get; set; }
        public int QtdProduct { get; set; }
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }

        public Produto()
        {
        }

        public Produto(int codProduct, int qtdProduct, string nameProduct, double priceProduct)
        {
            CodProduct = codProduct;
            QtdProduct = qtdProduct;
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
        }

        public static void CadastrarProdutoEstoque()
        {
            
        }

        public void ConsultarEstoque()
        {

        }
    }
}
