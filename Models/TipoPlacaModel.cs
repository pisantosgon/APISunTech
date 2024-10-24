namespace Api.Models
{
    public class TipoPlacaModel
    {
        public int TipoPlacaId { get; set; } 
        public string NomeTipoPlaca { get; set; } = string.Empty;

      
        public static implicit operator List<object>(TipoPlacaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
