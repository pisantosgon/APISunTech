namespace Api.Models
{
    public class Compra_Has_ProdutoModel
    {
        public int Compra_Has_ProdutoId { get; set; }

        public int CompraId { get; set; } 

        public int ProdutoId { get; set; }

        public int  QuantidadeProduto { get; set; }

        public double ValorUnitario { get; set; }

        public double ValorTotalProduto { get; set; }


        public static implicit operator List<object>(Compra_Has_ProdutoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
