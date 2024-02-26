using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CalculoProduto.DataAccess
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext>opts) : base(opts) { }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
