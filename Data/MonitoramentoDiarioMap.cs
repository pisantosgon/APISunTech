using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class MonitoramentoDiarioMap : IEntityTypeConfiguration<MonitoramentoDiarioModel>
    {
        public void Configure(EntityTypeBuilder<MonitoramentoDiarioModel> builder)
        {
            builder.HasKey(x => x.MonitoramentoDiarioId);
            builder.Property(x => x.DataDia).IsRequired().HasMaxLength(255);
            builder.Property(x => x.MediaDia).IsRequired().HasMaxLength(255);
            builder.Property(x => x.MonitoramentoId).IsRequired().HasMaxLength(255);
        }
    }
}
