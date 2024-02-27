namespace CalculoProduto.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Preparacao> Preparacoes { get; set; } = new List<Preparacao>();

        public Produto()
        {
            
        }
        public Produto(string nome, Preparacao preparacao)
        {
            Nome = nome;
            Preparacoes.Add(preparacao);
        }

        public void CriarPrecificacao(double valorMaoObra, double percentualLucro)
        {
            var preparacao = Preparacoes.FirstOrDefault();

            preparacao.CriarPrecificacao(valorMaoObra, percentualLucro);
        }
    }
}
