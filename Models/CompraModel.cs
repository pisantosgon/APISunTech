namespace Api.Models
{
    public class CompraModel
    {
        public int CompraId { get; set; }

        public int ClienteId { get; set; }

        public double TotalCompra { get; set; }

        public static implicit operator List<object>(CompraModel v)
        {
            throw new NotImplementedException();
        }
    }
}
