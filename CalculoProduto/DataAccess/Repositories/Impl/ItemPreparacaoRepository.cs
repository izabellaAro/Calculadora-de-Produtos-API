using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoProduto.DataAccess.Repositories.Impl
{
    public class ItemPreparacaoRepository : BaseRepository<ItemPreparacao>, IItemPreparacaoRepository
    {
        public ItemPreparacaoRepository(ProdutoContext context) : base(context) { }

        public async Task<IEnumerable<ItemPreparacao>> Listar()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
