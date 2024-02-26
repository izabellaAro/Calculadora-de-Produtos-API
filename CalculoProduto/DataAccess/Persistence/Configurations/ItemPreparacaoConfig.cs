using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CalculoProduto.DataAccess.Persistence.Configurations
{
    public class ItemPreparacaoConfig : IEntityTypeConfiguration<ItemPreparacao>
    {
        public void Configure(EntityTypeBuilder<ItemPreparacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Qnt);
            builder.Property(x => x.Valor);
            builder.HasOne(x => x.Preparacao).WithMany(p => p.ItensPreparacao).HasForeignKey(x => x.PreparacaoId);
            builder.HasOne(x => x.MateriaPrima).WithMany().HasForeignKey(x => x.MateriaPrimaId);
        }
    }
}
