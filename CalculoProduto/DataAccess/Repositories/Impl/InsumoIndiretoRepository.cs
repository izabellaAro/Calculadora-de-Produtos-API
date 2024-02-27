using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoProduto.DataAccess.Repositories.Impl
{
    public class InsumoIndiretoRepository : BaseRepository<InsumoIndireto>, IInsumoIndiretoRepository
    {
        public InsumoIndiretoRepository(ProdutoContext context): base(context) { }

        public async Task<IEnumerable<InsumoIndireto>> Listar()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
