using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoProduto.DataAccess.Repositories.Impl
{
    public class MateriaPrimaRepository : BaseRepository<MateriaPrima>, IMateriaPrimaRepository
    {
        public MateriaPrimaRepository(ProdutoContext context) : base(context) { }

        public async Task<IEnumerable<MateriaPrima>> Listar()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<MateriaPrima> BuscaMPId(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
