namespace CalculoProduto.Models.InsumoPreparacao
{
    public class CreateInsumoPreparacaoDto
    {
        public int Id { get; set; }
        public int PreparacaoId { get; set; }
        public int InsumoIndiretoId { get; set; }
        public double Valor { get; set; }
    }
}
