namespace Api.Models
{
    public class PlacaModel
    {
        public int PlacaId { get; set; }

        public string NomePlaca { get; set; } = string.Empty;

        public int TipoPlacaId { get; set; } 

        public string TamanhoPlaca { get; set; } = string.Empty;

        public static implicit operator List<object>(PlacaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
