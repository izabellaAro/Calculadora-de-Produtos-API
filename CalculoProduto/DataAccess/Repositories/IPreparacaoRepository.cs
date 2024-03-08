using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IPreparacaoRepository : IBaseRepository<Preparacao>
    {
        Task<IEnumerable<Preparacao>> Listar();
        Task<Preparacao> BuscaPreparacaoId(int id);
    }
}
