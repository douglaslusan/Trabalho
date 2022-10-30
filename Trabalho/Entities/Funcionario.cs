using System.Collections.Generic;


namespace Trabalho.Entities
{
    internal class Funcionario
    {
        public string Name { get; set; }
        public Cliente CodClient { get; set; }

        public Funcionario(string name, Cliente codClient)
        {
            Name = name;
            CodClient = codClient;
        }
    }
}
