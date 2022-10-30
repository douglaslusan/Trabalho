using System;
using System.Collections.Generic;


namespace Trabalho.Entities
{
    internal class Cliente
    {
        public int CodPerson { get; set; }
        public string NameClient { get; set; }
        
        List<Cliente> clientes = new List<Cliente>();

        public Cliente()
        {
        }

        public Cliente(int codPessoa, string nomeCliente)
        {
            CodPerson = codPessoa;
            NameClient = nomeCliente;
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
            return $"Codigo {CodPerson}\nNome {NameClient}";
        }

    }
}
