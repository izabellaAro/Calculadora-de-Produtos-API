namespace CalculoProduto.Entities
{
    public class Precificacao
    {
        public int Id { get; set; }
        public double CustoMP { get; private set; }
        public double CustoInsumo { get; private set; }
        public double CustoMO { get; private set; }
        public double PercentualLucro { get; private set; }
        public double TotalCusto { get; private set; }
        public double TotalVenda { get; private set; }
        public Preparacao Preparacao { get; set; }
        public int PreparacaoId { get; set; }

        public Precificacao()
        {
            
        }

        public Precificacao(int id, double custoMO, double percentualLucro)
        {
            Id = id;
            CustoMO = custoMO;
            PercentualLucro = percentualLucro;
        }

        public Precificacao(double custoMP, double custoInsumo, double custoMO, double percentualLucro)
        {
            CustoMP = custoMP;
            CustoInsumo = custoInsumo;
            CustoMO = custoMO;
            PercentualLucro = percentualLucro;
            TotalCusto = custoMO + custoInsumo + custoMP;
            CalcularTotalVenda(percentualLucro);
        }

        private void CalcularTotalVenda(double percentualLucro)
             => TotalVenda = TotalCusto * ConverterLucroParaCasasDecimais(percentualLucro);

        private static double ConverterLucroParaCasasDecimais(double percentualLucro) 
            => 1 + (percentualLucro / 100);
    }
}
