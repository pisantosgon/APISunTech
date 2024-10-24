namespace Api.Models
{
    public class ProdutoModel
    {
        public int ProdutoId { get; set; }

        public string NomeProduto { get; set; } = string.Empty;

        public int TipoProdutoId { get; set; } 

        public double PrecoProduto { get; set; } 

        public static implicit operator List<object>(ProdutoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
