using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ICompra_Has_ProdutoRepositorio
    {
        Task<List<Compra_Has_ProdutoModel>> GetAll();

        Task<Compra_Has_ProdutoModel> GetById(int id);

        Task<Compra_Has_ProdutoModel> InsertCompra_Has_Produto(Compra_Has_ProdutoModel compra_has_produto);

        Task<Compra_Has_ProdutoModel> UpdateCompra_Has_Produto(Compra_Has_ProdutoModel compra_has_produto, int id);

        Task<bool> DeleteCompra_Has_Produto(int id);
    }
}
