using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.HasKey(x => x.ProdutoId);
            builder.Property(x => x.NomeProduto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.FotoProduto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TipoProdutoId).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PrecoProduto).IsRequired().HasMaxLength(255);
        }
    }
}
