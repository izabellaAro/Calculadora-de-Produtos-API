using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IItemPreparacaoRepository
    {
        Task<IEnumerable<ItemPreparacao>> Listar();

    }
}
