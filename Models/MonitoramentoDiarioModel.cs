namespace Api.Models
{
    public class MonitoramentoDiarioModel
    {
        public int MonitoramentoDiarioId { get; set; }

        public DateTime DataDia { get; set; }

        public int MediaDia { get; set; }

        public int MonitoramentoId { get; set; } 

        public static implicit operator List<object>(MonitoramentoDiarioModel v)
        {
            throw new NotImplementedException();
        }
    }
}
