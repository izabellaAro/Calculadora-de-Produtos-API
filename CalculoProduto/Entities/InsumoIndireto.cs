namespace CalculoProduto.Entities
{
    public class InsumoIndireto
    {
        public int Id { get; set; }
        public string Especificao { get; set; }
        public double Valor { get; set; }

        public InsumoIndireto()
        {
            
        }
        
        public InsumoIndireto(string especificacao, double valor)
        {
            Especificao = especificacao;
            Valor = valor;
        }
    }
}
