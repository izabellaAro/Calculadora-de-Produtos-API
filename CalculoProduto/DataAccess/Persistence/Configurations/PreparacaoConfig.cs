using CalculoProduto.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalculoProduto.DataAccess.Persistence.Configurations
{
    public class PreparacaoConfig : IEntityTypeConfiguration<Preparacao>
    {
        public void Configure(EntityTypeBuilder<Preparacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.HasOne(x => x.Produto).WithMany(p => p.Preparacoes).HasForeignKey(x => x.ProdutoId).IsRequired();
            builder.HasOne(x => x.Precificacao).WithOne(p => p.Preparacao).HasForeignKey<Precificacao>(x => x.PreparacaoId);
        }
    }
}
