using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<CompraModel> Compra { get; set; }
        public DbSet<Compra_Has_ProdutoModel> Compra_Has_Produto { get; set; }
        public DbSet<TipoProdutoModel> TipoProduto { get; set; }
        public DbSet<PlacaModel> Placa { get; set; }
        public DbSet<TipoPlacaModel> TipoPlaca { get; set; }
        public DbSet<MonitoramentoModel> Monitoramento { get; set; }
        public DbSet<MonitoramentoDiarioModel> MonitoramentoDiario { get; set; }
        public DbSet<MonitoramentoMensalModel> MonitoramentoMensal { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new CompraMap());
            modelBuilder.ApplyConfiguration(new Compra_Has_ProdutoMap());
            modelBuilder.ApplyConfiguration(new TipoProdutoMap());
            modelBuilder.ApplyConfiguration(new PlacaMap());
            modelBuilder.ApplyConfiguration(new TipoPlacaMap());
            modelBuilder.ApplyConfiguration(new MonitoramentoMap());
            modelBuilder.ApplyConfiguration(new MonitoramentoDiarioMap());
            modelBuilder.ApplyConfiguration(new MonitoramentoMensalMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
