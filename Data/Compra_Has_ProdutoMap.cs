using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Compra_Has_ProdutoMap : IEntityTypeConfiguration<Compra_Has_ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<Compra_Has_ProdutoModel> builder)
        {
            builder.HasKey(x => x.Compra_Has_ProdutoId);
            builder.Property(x => x.CompraId).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ProdutoId).IsRequired().HasMaxLength(255);
            builder.Property(x => x.QuantidadeProduto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ValorUnitario).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ValorTotalProduto).IsRequired().HasMaxLength(255);
        }
    }
}
