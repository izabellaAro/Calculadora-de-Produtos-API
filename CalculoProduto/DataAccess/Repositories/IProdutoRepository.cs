using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> Listar(); 
    }
}
