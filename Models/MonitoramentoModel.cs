namespace Api.Models
{
    public class MonitoramentoModel
    {
        public int MonitoramentoId { get; set; }

        public int PlacaId { get; set; } 

        public int QuantidadePlaca { get; set; }

        public int ClienteId { get; set; }

        public DateTime DataInstalacao { get; set; }

        public DateTime DataUltimaManutencao { get; set; }


        public static implicit operator List<object>(MonitoramentoModel v)

        {
            throw new NotImplementedException();
        }
    }
}
