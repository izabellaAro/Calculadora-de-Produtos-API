namespace CalculoProduto.Entities
{
    public class ItemPreparacao
    {
        public int Id { get; set; }
        public int PreparacaoId { get; set; }
        public Preparacao Preparacao { get; set; }
        public int MateriaPrimaId { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public double Qnt { get; set; }
        public double Valor { get; set; }
    }
}
