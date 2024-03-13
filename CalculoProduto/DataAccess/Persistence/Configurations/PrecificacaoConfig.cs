using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalculoProduto.DataAccess.Persistence.Configurations
{
    public class PrecificacaoConfig : IEntityTypeConfiguration<Precificacao>
    {
        public void Configure(EntityTypeBuilder<Precificacao> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.CustoMP).IsRequired();
            builder.Property(x => x.CustoMO).IsRequired();
            builder.Property(x => x.CustoInsumo);
            builder.Property(x => x.PercentualLucro).IsRequired();
            builder.Property(x => x.TotalCusto);
            builder.Property(x => x.TotalVenda);
        }
    }
}
