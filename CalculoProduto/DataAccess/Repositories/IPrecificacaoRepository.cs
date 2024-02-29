using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IPrecificacaoRepository
    {
        Task<IEnumerable<Precificacao>> Listar();
    }
}
