using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ICompraRepositorio
    {
        Task<List<CompraModel>> GetAll();

        Task<CompraModel> GetById(int id);

        Task<CompraModel> InsertCompra(CompraModel compra);

        Task<CompraModel> UpdateCompra(CompraModel compra, int id);

        Task<bool> DeleteCompra(int id);
    }
}
