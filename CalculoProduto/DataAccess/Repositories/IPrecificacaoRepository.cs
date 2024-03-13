using CalculoProduto.DataAccess.Repositories.Impl;
using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Repositories
{
    public interface IPrecificacaoRepository : IBaseRepository<Precificacao>
    {
        Task<IEnumerable<Precificacao>> Listar();
    }
}
