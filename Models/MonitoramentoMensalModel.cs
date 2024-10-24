namespace Api.Models
{
    public class MonitoramentoMensalModel
    {
        public int MonitoramentoMensalId { get; set; }

        public DateTime Mes { get; set; } 

        public int MediaMensal { get; set; } 

        public int MonitoramentoId { get; set; } 

        public static implicit operator List<object>(MonitoramentoMensalModel v)
        {
            throw new NotImplementedException();
        }
    }
}
