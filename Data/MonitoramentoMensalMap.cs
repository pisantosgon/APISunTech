using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class MonitoramentoMensalMap : IEntityTypeConfiguration<MonitoramentoMensalModel>
    {
        public void Configure(EntityTypeBuilder<MonitoramentoMensalModel> builder)
        {
            builder.HasKey(x => x.MonitoramentoMensalId);
            builder.Property(x => x.Mes).IsRequired().HasMaxLength(255);
            builder.Property(x => x.MediaMensal).IsRequired().HasMaxLength(255);
            builder.Property(x => x.MonitoramentoId).IsRequired().HasMaxLength(255);
        }
    }
}
