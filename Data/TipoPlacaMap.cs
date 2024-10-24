using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class TipoPlacaMap : IEntityTypeConfiguration<TipoPlacaModel>
    {
        public void Configure(EntityTypeBuilder<TipoPlacaModel> builder)
        {
            builder.HasKey(x => x.TipoPlacaId);
            builder.Property(x => x.NomeTipoPlaca).IsRequired().HasMaxLength(255);
        }
    }
}
