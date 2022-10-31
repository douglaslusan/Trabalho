using System;
using System.Collections.Generic;


namespace Trabalho.Entities
{
    internal class Cliente
    {
        public int CodPessoal { get; set; }
        public string Nome { get; set; }
        
        List<Cliente> clientes = new List<Cliente>();

        public Cliente()
        {
        }

        public Cliente(int codPessoa, string nome)
        {
            CodPessoal = codPessoa;
            Nome = nome;
        }


        public void Cadastrar(int n, string nome)
        {
            clientes.Add(new Cliente(n, nome));
        }
        
        
        public void Consultar()
        {
            foreach (Cliente item in clientes)
            {
                Console.WriteLine(item);
            }
        }
        

        public override string ToString()
        {
            return $"Codigo {CodPessoal}\nNome {Nome}\n";
        }

    }
}
