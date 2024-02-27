using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoProduto.Entities
{
    public class Preparacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int PrecificacaoId { get; set; }
        public Precificacao Precificacao { get; set; }
        public IList<ItemPreparacao> ItensPreparacao { get; set; }
        public IList<InsumoPreparacao> InsumosPreparacao { get; set; }
        [NotMapped]
        public double TotalValorMP => ItensPreparacao.Sum(x => x.Valor);
        [NotMapped]
        public double TotalValorInsumos => InsumosPreparacao.Sum(x => x.Valor);

        public Preparacao()
        {
            
        }

        public void CriarPrecificacao(double valorMaoObra, double percentualLucro)
        {
            Precificacao = new Precificacao(TotalValorMP, TotalValorInsumos,
                valorMaoObra, percentualLucro);
        }
    }
}
