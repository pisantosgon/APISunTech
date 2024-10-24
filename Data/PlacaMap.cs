using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class PlacaMap : IEntityTypeConfiguration<PlacaModel>
    {
        public void Configure(EntityTypeBuilder<PlacaModel> builder)
        {
            builder.HasKey(x => x.PlacaId);
            builder.Property(x => x.NomePlaca).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TipoPlacaId).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TamanhoPlaca).IsRequired().HasMaxLength(255);
        }
    }
}
