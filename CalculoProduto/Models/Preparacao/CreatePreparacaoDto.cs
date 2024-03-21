namespace CalculoProduto.Models.Preparacao
{
    public class CreatePreparacaoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProdutoId { get; set; }
        public double ValorMaoObra { get; set; }
        public double PercentualLucro { get; set; }
        public List<CreateItemPreparacaoDto> ItensPreparacao { get; set; }
        public List<CreateInsumoPreparacaoDto> InsumosPreparacao { get; set; }
    }

    public class CreateItemPreparacaoDto
    {
        public int Id { get; set; }
        public int MateriaPrimaId { get; set; }
        public double Qnt { get; set; }
        public double Valor { get; set; }
    }

    public class CreateInsumoPreparacaoDto
    {
        public int Id { get; set; }
        public int InsumoIndiretoId { get; set; }
        public double Valor { get; set; }
    }
}
