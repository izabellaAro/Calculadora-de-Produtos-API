namespace CalculoProduto.Entities
{
    public class InsumoIndireto
    {
        public int Id { get; set; }
        public string Especificacao { get; set; }
        public double Valor { get; set; }

        public InsumoIndireto()
        {
            
        }
        
        public InsumoIndireto(string especificacao, double valor)
        {
            Especificacao = especificacao;
            Valor = valor;
        }
    }
}
