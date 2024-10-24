using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class CompraMap : IEntityTypeConfiguration<CompraModel>
    {
        public void Configure(EntityTypeBuilder<CompraModel> builder)
        {
            builder.HasKey(x => x.CompraId);
            builder.Property(x => x.ClienteId).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TotalCompra).IsRequired().HasMaxLength(255);
        }
    }
}
