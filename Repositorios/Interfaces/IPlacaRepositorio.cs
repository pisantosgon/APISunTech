using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IPlacaRepositorio
    {
        Task<List<PlacaModel>> GetAll();

        Task<PlacaModel> GetById(int id);

        Task<PlacaModel> InsertPlaca(PlacaModel placa);

        Task<PlacaModel> UpdatePlaca(PlacaModel placa, int id);

        Task<bool> DeletePlaca(int id);
    }
}
