using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalculoProduto.DataAccess.Persistence.Configurations
{
    public class InsumoPreparacaoConfig : IEntityTypeConfiguration<InsumoPreparacao>
    {
        public void Configure(EntityTypeBuilder<InsumoPreparacao>builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Valor);
            builder.HasOne(x => x.Preparacao).WithMany(p => p.InsumosPreparacao).HasForeignKey(x => x.PreparacaoId);
            builder.HasOne(x => x.Insumo).WithMany().HasForeignKey(x => x.InsumoIndiretoId);
        }
    }
}
