using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        Task<IEnumerable<Produto>> Listar();
        Task<Produto> BuscaProdutoId(int id);
    }
}
