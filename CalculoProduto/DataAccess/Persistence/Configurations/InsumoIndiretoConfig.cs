using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CalculoProduto.Entities;

namespace CalculoProduto.DataAccess.Persistence.Configurations
{
    public class InsumoIndiretoConfig : IEntityTypeConfiguration<InsumoIndireto>
    {
        public void Configure(EntityTypeBuilder<InsumoIndireto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Especificacao).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
        }
    }
}
