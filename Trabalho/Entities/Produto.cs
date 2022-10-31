using System;
using System.Collections.Generic;


namespace Trabalho.Entities
{
    public class Produto
    {
        public int CodProduct { get; set; }
        public int QtdProduct { get; set; }
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }

        
        public Produto(int codProduct, int qtdProduct, string nameProduct, double priceProduct)
        {
            CodProduct = codProduct;
            QtdProduct = qtdProduct;
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
        }

        public override string ToString()
        {
            return $"Cod: {CodProduct}\nQtd: {QtdProduct}\nNome: {NameProduct}\nPreco: {PriceProduct}\n";
        }
    }
}
