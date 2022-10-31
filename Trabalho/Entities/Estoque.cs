using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Entities
{
    class Estoque
    {
        

        List<Produto> listaEstoque = new List<Produto>();

        
        public void CadastrarEstoque(Produto produto)
        {
            listaEstoque.Add(new Produto(produto.CodProduct, produto.QtdProduct, produto.NameProduct, produto.PriceProduct));
        }

        public void BuscarEstoque()
        {
            foreach (var item in listaEstoque)
            {
                Console.WriteLine(item);
            }
        }

        

    }
}
