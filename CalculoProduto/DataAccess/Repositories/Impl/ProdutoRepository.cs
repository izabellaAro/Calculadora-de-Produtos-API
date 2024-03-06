using CalculoProduto.Entities;
using CalculoProduto.Models.Produto;
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
        public async Task<Produto> BuscaProdutoId(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
