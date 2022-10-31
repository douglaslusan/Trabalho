using System.IO;
using Trabalho.Entities;

internal class Program
{
    private static void Main(string[] args)
    {

        Cliente cliente = new Cliente();
        Estoque estoque = new Estoque();
        Funcionario funcionario = new Funcionario();

        Console.WriteLine("DIGITE A OPCAO");
        Console.WriteLine("C: CADASTRAR\nB: BUSCAR\nS: SAIR");
        char opcao = char.Parse(Console.ReadLine().ToUpper());

        while (opcao != 'S')
        {
            switch (opcao)
            {
                case 'C':
                    Console.WriteLine("DIGITE A OPCAO DE CADASTRO:");
                    Console.WriteLine("C: CLIENTE\nF: FUNCIONARIO\nP: PRODUTO");
                    char opcao1 = char.Parse(Console.ReadLine().ToUpper());
                    switch (opcao1)
                    {
                        case 'C':
                            Console.Write("Digite o Codigo: ");
                            int n = int.Parse(Console.ReadLine());
                            Console.Write("Digite o nome do Cliente: ");
                            string nome = Console.ReadLine();
                            cliente.Cadastrar(n, nome);
                            break;

                        case 'F':
                            Console.Write("Digite o Codigo: ");
                            int n1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o nome do funcionario: ");
                            string nomefunc = Console.ReadLine();
                            Console.Write("Digite o salario do funcionario: ");
                            double salario = double.Parse(Console.ReadLine());
                            funcionario.CadastrarFunc(salario, n1, nomefunc);
                            break;

                        case 'P':
                            Console.Write("Digite o Codigo do produto: ");
                            int cod = int.Parse(Console.ReadLine());
                            Console.Write("Digite a qtdade do produto: ");
                            int qtd = int.Parse(Console.ReadLine());
                            Console.Write("Digite o nome do produto: ");
                            string nomeprod = Console.ReadLine();
                            Console.Write("Digite o preco ");
                            double preco = double.Parse(Console.ReadLine());
                            estoque.CadastrarEstoque(new Produto(cod, qtd, nomeprod, preco));
                            break;

                        default:

                            break;
                    }
                    break;
                case 'B':
                    Console.WriteLine("DIGITE A OPCAO DE BUSCA:");
                    Console.WriteLine("C: CLIENTE\nF: FUNCIONARIO\nP: PRODUTO");
                    opcao1 = char.Parse(Console.ReadLine().ToUpper());
                    switch (opcao1)
                    {
                        case 'C':
                            cliente.Consultar();
                            Console.ReadKey();
                            break;

                        case 'F':
                            funcionario.BuscarFunc();
                            Console.ReadKey();
                            break;

                        case 'P':
                            estoque.BuscarEstoque();
                            Console.ReadKey();
                            break;

                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.Clear();

            Console.WriteLine("DIGITE A OPCAO");
            Console.WriteLine("C: CADASTRAR\nB: BUSCAR\nS: SAIR");
            opcao = char.Parse(Console.ReadLine().ToUpper());

        }
        
                
    }
}