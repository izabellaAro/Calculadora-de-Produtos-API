using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoProduto.DataAccess.Repositories.Impl
{
    public class PreparacaoRepository : BaseRepository<Preparacao>, IPreparacaoRepository
    {
        public PreparacaoRepository(ProdutoContext context) : base(context) { }

        public async Task<IEnumerable<Preparacao>> Listar()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
