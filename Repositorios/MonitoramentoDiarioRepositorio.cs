using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class MonitoramentoDiarioRepositorio : IMonitoramentoDiarioRepositorio
    {
        private readonly Contexto _dbContext;

        public MonitoramentoDiarioRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MonitoramentoDiarioModel>> GetAll()
        {
            return await _dbContext.MonitoramentoDiario.ToListAsync();
        }

        public async Task<MonitoramentoDiarioModel> GetById(int id)
        {
            return await _dbContext.MonitoramentoDiario.FirstOrDefaultAsync(x => x.MonitoramentoDiarioId == id);
        }

        public async Task<MonitoramentoDiarioModel> InsertMonitoramentoDiario(MonitoramentoDiarioModel monitoramentodiario)
        {
            await _dbContext.MonitoramentoDiario.AddAsync(monitoramentodiario);
            await _dbContext.SaveChangesAsync();
            return monitoramentodiario;
        }

        public async Task<MonitoramentoDiarioModel> UpdateMonitoramentoDiario(MonitoramentoDiarioModel monitoramentodiario, int id)
        {
            MonitoramentoDiarioModel monitoramentodiarios = await GetById(id);
            if (monitoramentodiarios == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                monitoramentodiarios.MonitoramentoDiarioId = monitoramentodiario.MonitoramentoDiarioId;
                monitoramentodiarios.DataDia = monitoramentodiario.DataDia;
                monitoramentodiarios.MediaDia = monitoramentodiario.MediaDia;
                monitoramentodiarios.MonitoramentoId = monitoramentodiario.MonitoramentoId;
                _dbContext.MonitoramentoDiario.Update(monitoramentodiarios);
                await _dbContext.SaveChangesAsync();
            }
            return monitoramentodiarios;

        }

        public async Task<bool> DeleteMonitoramentoDiario(int id)
        {
            MonitoramentoDiarioModel monitoramentodiarios = await GetById(id);
            if (monitoramentodiarios == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.MonitoramentoDiario.Remove(monitoramentodiarios);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}