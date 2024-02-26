using CalculoProduto.Application.Services;
using CalculoProduto.Entities;

namespace CalculoProduto.Application.Services.Impl
{
    public class ProdutoService : IProdutoService
    {
        public async Task CadastrarProduto()
        {
            // Criar insumos
            var insumosPreparacao = new List<InsumoPreparacao>();
            var insumoGas = new InsumoIndireto { Especificao = "Gás" };

            insumosPreparacao.Add(new InsumoPreparacao { Insumo = insumoGas, Valor = 5 });

            // Criar materias primas
            var farinhaTrigo = new MateriaPrima { Nome = "Farinha De Trigo", Qnts = 3, Valor = 10 };

            // Criar intens preparacao
            var itensPreparacao = new List<ItemPreparacao>();
            var farinhaBolo = new ItemPreparacao { MateriaPrima = farinhaTrigo, Qnt = 1, Valor = 3.3 };

            itensPreparacao.Add(farinhaBolo);
            // Criar preparacao
            var preparacaoBolo = new Preparacao
            {
                ItensPreparacao = itensPreparacao,
                InsumosPreparacao = insumosPreparacao
            };

            // Criar Produto
            var boloChocolate = new Produto("Bolo de Chocolate", preparacaoBolo);

            const double valorMO = 15;
            const double percentualLucro = 25;
            boloChocolate.CriarPrecificacao(valorMO, percentualLucro);
        }
    }
}
