using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IMonitoramentoDiarioRepositorio
    {
        Task<List<MonitoramentoDiarioModel>> GetAll();

        Task<MonitoramentoDiarioModel> GetById(int id);

        Task<MonitoramentoDiarioModel> InsertMonitoramentoDiario(MonitoramentoDiarioModel monitoramentodiario);

        Task<MonitoramentoDiarioModel> UpdateMonitoramentoDiario(MonitoramentoDiarioModel monitoramentodiario, int id);

        Task<bool> DeleteMonitoramentoDiario(int id);
    }
}
