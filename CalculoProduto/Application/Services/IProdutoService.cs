using CalculoProduto.Entities;
using CalculoProduto.Models.Produto;

namespace CalculoProduto.Application.Services
{
    public interface IProdutoService
    {
        Task CadastrarProduto(CreateProdutoDto produtoDto);
        Task<IEnumerable<ReadProdutoDto>> ListaProdutos();
        Task<ReadProdutoDto> BuscaProdutoId(int id);
    }
}
