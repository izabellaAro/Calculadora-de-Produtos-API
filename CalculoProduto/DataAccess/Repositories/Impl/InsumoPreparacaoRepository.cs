using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoProduto.DataAccess.Repositories.Impl
{
    public class InsumoPreparacaoRepository : BaseRepository<InsumoPreparacao>, IInsumoPreparacaoRepository
    {
        public InsumoPreparacaoRepository(ProdutoContext context) : base(context) { }

        public async Task<IEnumerable<InsumoPreparacao>> Listar()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
