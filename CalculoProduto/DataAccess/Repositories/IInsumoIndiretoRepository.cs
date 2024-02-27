using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IInsumoIndiretoRepository
    {
        Task<IEnumerable<InsumoIndireto>> Listar();
    }
}
