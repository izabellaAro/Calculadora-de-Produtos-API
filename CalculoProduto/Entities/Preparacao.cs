using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace CalculoProduto.Entities
{
    public class Preparacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public Precificacao Precificacao { get; set; }
        public IList<ItemPreparacao> ItensPreparacao { get; set; } = new List<ItemPreparacao>();
        public IList<InsumoPreparacao> InsumosPreparacao { get; set; } = new List<InsumoPreparacao>();
        [NotMapped]
        public double TotalValorMP => ItensPreparacao.Sum(x => x.Valor);
        [NotMapped]
        public double TotalValorInsumos => InsumosPreparacao.Sum(x => x.Valor);

        public Preparacao()
        {
            
        }

        public Preparacao(int id, string nome, int produtoId)
        {
            Id = id;
            Nome = nome;
            ProdutoId = produtoId;
        }

        public void CriarPrecificacao(double valorMaoObra, double percentualLucro)
        {
            Precificacao = new Precificacao(TotalValorMP, TotalValorInsumos,
                valorMaoObra, percentualLucro);
        }

        public void AdicionarItem(int materiaPrimaId, double qnt, double valor)
        {
            ItensPreparacao.Add(new ItemPreparacao(this, materiaPrimaId, qnt, valor));
        }

        public void AdicionarInsumo(int insumoIndiretoId, double valor)
        {
            InsumosPreparacao.Add(new InsumoPreparacao(this, insumoIndiretoId, valor));
        }
    }
}
