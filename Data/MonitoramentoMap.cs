using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class MonitoramentoMap : IEntityTypeConfiguration<MonitoramentoModel>
    {
        public void Configure(EntityTypeBuilder<MonitoramentoModel> builder)
        {
            builder.HasKey(x => x.MonitoramentoId);
            builder.Property(x => x.PlacaId).IsRequired().HasMaxLength(255);
            builder.Property(x => x.QuantidadePlaca).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ClienteId).IsRequired().HasMaxLength(255);
            builder.Property(x => x.DataInstalacao).IsRequired().HasMaxLength(255);
            builder.Property(x => x.DataUltimaManutencao).IsRequired().HasMaxLength(255);
        }
    }
}
