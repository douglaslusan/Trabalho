using System.Collections.Generic;


namespace Trabalho.Entities
{
    internal class Funcionario
    {
        
        public double Salario { get; set; }
        public int CodPessoal { get; set; }
        public string Nome { get; set; }

        List<Funcionario> funcionarios = new List<Funcionario>();

        public Funcionario()
        {
        }

        public Funcionario(double salario, int codPessoa, string nome) 
        {
            Salario = salario;
            CodPessoal = codPessoa;
            Nome = nome;
        }

        public void CadastrarFunc(double salario, int codPessoa, string nome)
        {
            funcionarios.Add(new Funcionario(salario, codPessoa, nome));
        }

        public void BuscarFunc()
        {
            foreach (var item in funcionarios)
            {
                Console.WriteLine(item);
            }
        }

        public override string ToString()
        {
            return $"Cod: {CodPessoal}\nNome: {Nome}\nSalario: {Salario}\n";
        }

    }
}
