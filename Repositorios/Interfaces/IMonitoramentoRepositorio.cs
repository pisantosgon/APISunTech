using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IMonitoramentoRepositorio
    {
        Task<List<MonitoramentoModel>> GetAll();

        Task<MonitoramentoModel> GetById(int id);

        Task<MonitoramentoModel> InsertMonitoramento(MonitoramentoModel monitoramento);

        Task<MonitoramentoModel> UpdateMonitoramento(MonitoramentoModel monitoramento, int id);

        Task<bool> DeleteMonitoramento(int id);
    }
}
