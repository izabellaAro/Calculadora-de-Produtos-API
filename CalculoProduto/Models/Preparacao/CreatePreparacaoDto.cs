namespace CalculoProduto.Models.Preparacao
{
    public class CreatePreparacaoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProdutoId { get; set; }
        public List<ItemPreparacaoDto> ItensPreparacao { get; set; }
        public List<InsumoPreparacaoDto> InsumosPreparacao { get; set; }
    }

    public class ItemPreparacaoDto
    {
        public int Id { get; set; }
        public int MateriaPrimaId { get; set; }
        public double Qnt { get; set; }
        public double Valor { get; set; }
    }

    public class InsumoPreparacaoDto
    {
        public int Id { get; set; }
        public int InsumoIndiretoId { get; set; }
        public double Valor { get; set; }
    }
}
