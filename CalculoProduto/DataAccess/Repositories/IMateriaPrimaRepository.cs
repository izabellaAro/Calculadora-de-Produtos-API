using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IMateriaPrimaRepository : IBaseRepository<MateriaPrima>
    {
        Task<IEnumerable<MateriaPrima>> Listar();
    }
}
