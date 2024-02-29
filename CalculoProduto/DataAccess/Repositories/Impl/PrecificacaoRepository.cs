using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoProduto.DataAccess.Repositories.Impl
{
    public class PrecificacaoRepository : BaseRepository<Precificacao>, IPrecificacaoRepository
    {
        public PrecificacaoRepository(ProdutoContext context) : base(context) { }

        public async Task<IEnumerable<Precificacao>> Listar()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
