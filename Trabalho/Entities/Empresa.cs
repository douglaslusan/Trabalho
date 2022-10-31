

namespace Trabalho.Entities
{
    internal class Empresa
    {
        public int CodEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public int NumFuncionario { get; set; }
        public double ReceitaBruta { get; set; }
        public double FolhaSalarial { get; set; }

        public Empresa(int codEmpresa, string nomeEmpresa, int numFuncionario, double receitaBruta, double folhaSalarial)
        {
            CodEmpresa = codEmpresa;
            NomeEmpresa = nomeEmpresa;
            NumFuncionario = numFuncionario;
            ReceitaBruta = receitaBruta;
            FolhaSalarial = folhaSalarial;
        }
    }
}
