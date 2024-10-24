using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class MonitoramentoMensalRepositorio : IMonitoramentoMensalRepositorio
    {
        private readonly Contexto _dbContext;

        public MonitoramentoMensalRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MonitoramentoMensalModel>> GetAll()
        {
            return await _dbContext.MonitoramentoMensal.ToListAsync();
        }

        public async Task<MonitoramentoMensalModel> GetById(int id)
        {
            return await _dbContext.MonitoramentoMensal.FirstOrDefaultAsync(x => x.MonitoramentoMensalId == id);
        }

        public async Task<MonitoramentoMensalModel> InsertMonitoramentoMensal(MonitoramentoMensalModel monitoramentomensal)
        {
            await _dbContext.MonitoramentoMensal.AddAsync(monitoramentomensal);
            await _dbContext.SaveChangesAsync();
            return monitoramentomensal;
        }

        public async Task<MonitoramentoMensalModel> UpdateMonitoramentoMensal(MonitoramentoMensalModel monitoramentomensal, int id)
        {
            MonitoramentoMensalModel monitoramentomensais = await GetById(id);
            if (monitoramentomensais == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                monitoramentomensais.Mes = monitoramentomensal.Mes;
                monitoramentomensais.MediaMensal = monitoramentomensal.MediaMensal;
                monitoramentomensais.MonitoramentoId = monitoramentomensal.MonitoramentoId;
                _dbContext.MonitoramentoMensal.Update(monitoramentomensais);
                await _dbContext.SaveChangesAsync();
            }
            return monitoramentomensais;

        }

        public async Task<bool> DeleteMonitoramentoMensal(int id)
        {
            MonitoramentoMensalModel monitoramentomensais = await GetById(id);
            if (monitoramentomensais == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.MonitoramentoMensal.Remove(monitoramentomensais);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}