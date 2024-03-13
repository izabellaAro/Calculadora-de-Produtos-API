using CalculoProduto.Models.Precificacao;

namespace CalculoProduto.Models.Preparacao
{
    public class ReadPreparacaoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProdutoId { get; set; }
        public ReadPrecificacaoDto PrecificacaoDto { get; set; }
        public List<ReadItemPreparacaoDto> ItensPreparacao { get; set; }
        public List<ReadInsumoPreparacaoDto> InsumosPreparacao { get; set; }
    }

    public class ReadItemPreparacaoDto
    {
        public int Id { get; set; }
        public int MateriaPrimaId { get; set; }
        public double Qnt { get; set; }
        public double Valor { get; set; }
    }

    public class ReadInsumoPreparacaoDto
    {
        public int Id { get; set; }
        public int InsumoIndiretoId { get; set; }
        public double Valor { get; set; }
    }
}
