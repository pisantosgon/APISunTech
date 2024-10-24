using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.HasKey(x => x.ClienteId);
            builder.Property(x => x.NomeCliente).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CpfCliente).IsRequired().HasMaxLength(255);
            builder.Property(x => x.EmailCliente).IsRequired().HasMaxLength(255);
            builder.Property(x => x.SenhaCliente).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TelefoneCliente).IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnderecoCliente).IsRequired().HasMaxLength(255);
        }
    }
}
