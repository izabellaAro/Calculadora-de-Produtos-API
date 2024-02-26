using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalculoProduto.DataAccess.Persistence.Configurations
{
    public class MateriaPrimaConfig : IEntityTypeConfiguration<MateriaPrima>
    {
        public void Configure(EntityTypeBuilder<MateriaPrima> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Qnts).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
        }
    }
}
