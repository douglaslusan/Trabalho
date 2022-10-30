using Trabalho.Entities;

internal class Program
{
    private static void Main(string[] args)
    {

        Cliente cliente = new Cliente();

        Console.WriteLine("DIGITE A OPCAO");
        Console.WriteLine("C: CADASTRAR\nB: BUSCAR\nS: SAIR");
        char opcao = char.Parse(Console.ReadLine().ToUpper());

        while (opcao != 'S')
        {
            switch (opcao)
            {
                case 'C':
                    Console.WriteLine("Digite o cod");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o Nome");
                    string nome = Console.ReadLine();

                    cliente.Cadastrar(n, nome);
                    break;
                case 'B':
                    cliente.Consultar();
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