namespace CalculoProduto.Models.ItemPreparacao
{
    public class CreateItemPreparacaoDto
    {
        public int Id { get; set; }
        public int PreparacaoId { get; set; }
        public int MateriaPrimaId { get; set; }
        public double Qnt { get; set; }
        public double Valor { get; set; }
    }
}
