using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IMonitoramentoMensalRepositorio
    {
        Task<List<MonitoramentoMensalModel>> GetAll();

        Task<MonitoramentoMensalModel> GetById(int id);

        Task<MonitoramentoMensalModel> InsertMonitoramentoMensal(MonitoramentoMensalModel monitoramentomensal);

        Task<MonitoramentoMensalModel> UpdateMonitoramentoMensal(MonitoramentoMensalModel monitoramentomensal, int id);

        Task<bool> DeleteMonitoramentoMensal(int id);
    }
}
