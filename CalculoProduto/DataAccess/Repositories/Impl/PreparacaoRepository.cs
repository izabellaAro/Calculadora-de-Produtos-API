using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoProduto.DataAccess.Repositories.Impl
{
    public class PreparacaoRepository : BaseRepository<Preparacao>, IPreparacaoRepository
    {
        public PreparacaoRepository(ProdutoContext context) : base(context) { }

        public async Task<IEnumerable<Preparacao>> Listar()
        {
            return await _dbSet
                .Include(preparacao => preparacao.ItensPreparacao)
                .Include(preparacao => preparacao.InsumosPreparacao)
                .ToListAsync();
        }

        public async Task<Preparacao> BuscaPreparacaoId(int id)
        {
            return await _dbSet
                .Include(preparacao => preparacao.ItensPreparacao)
                .Include(preparacao => preparacao.InsumosPreparacao)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
