namespace CalculoProduto.Entities
{
    public class InsumoPreparacao
    {
        public int Id { get; set; }
        public int PreparacaoId { get; set; }
        public Preparacao Preparacao { get; set; }
        public int InsumoIndiretoId { get; set; }
        public InsumoIndireto Insumo { get; set; }
        public double Valor { get; set; }

        public InsumoPreparacao()
        {
            
        }

        public InsumoPreparacao(Preparacao preparacao, int insumoIndiretoId, double valor)
        {
            Preparacao = preparacao;
            InsumoIndiretoId = insumoIndiretoId;
            Valor = valor;
        }
    }
}
