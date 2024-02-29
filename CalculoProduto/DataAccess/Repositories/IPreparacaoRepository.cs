using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IPreparacaoRepository
    {
        Task<IEnumerable<Preparacao>> Listar();
    }
}
