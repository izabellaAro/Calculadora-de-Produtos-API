using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IInsumoPreparacaoRepository
    {
        Task<IEnumerable<InsumoPreparacao>> Listar();

    }
}
