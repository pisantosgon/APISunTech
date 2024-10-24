using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ITipoPlacaRepositorio
    {
        Task<List<TipoPlacaModel>> GetAll();

        Task<TipoPlacaModel> GetById(int id);

        Task<TipoPlacaModel> InsertTipoPlaca(TipoPlacaModel tipoplaca);

        Task<TipoPlacaModel> UpdateTipoPlaca(TipoPlacaModel tipoplaca, int id);

        Task<bool> DeleteTipoPlaca(int id);
    }
}
