using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IInsumoIndiretoRepository : IBaseRepository<InsumoIndireto>
    {
        Task<IEnumerable<InsumoIndireto>> Listar();
        Task<InsumoIndireto> BuscaInsIndiretoId(int id);
    }
}
