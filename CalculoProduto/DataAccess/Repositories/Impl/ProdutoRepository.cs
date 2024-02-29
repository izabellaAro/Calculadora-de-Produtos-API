using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoProduto.DataAccess.Repositories.Impl
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ProdutoContext context) : base(context) { }

        public async Task<IEnumerable<Produto>> Listar()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
