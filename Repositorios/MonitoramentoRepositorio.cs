using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class MonitoramentoRepositorio : IMonitoramentoRepositorio
    {
        private readonly Contexto _dbContext;

        public MonitoramentoRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MonitoramentoModel>> GetAll()
        {
            return await _dbContext.Monitoramento.ToListAsync();
        }

        public async Task<MonitoramentoModel> GetById(int id)
        {
            return await _dbContext.Monitoramento.FirstOrDefaultAsync(x => x.MonitoramentoId == id);
        }

        public async Task<MonitoramentoModel> InsertMonitoramento(MonitoramentoModel monitoramento)
        {
            await _dbContext.Monitoramento.AddAsync(monitoramento);
            await _dbContext.SaveChangesAsync();
            return monitoramento;
        }

        public async Task<MonitoramentoModel> UpdateMonitoramento(MonitoramentoModel monitoramento, int id)
        {
            MonitoramentoModel monitoramentos = await GetById(id);
            if (monitoramentos == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                monitoramentos.MonitoramentoId = monitoramento.MonitoramentoId;
                monitoramentos.PlacaId = monitoramento.PlacaId;
                monitoramentos.QuantidadePlaca = monitoramento.QuantidadePlaca;
                monitoramentos.ClienteId = monitoramento.ClienteId;
                monitoramentos.DataInstalacao = monitoramento.DataInstalacao;
                monitoramentos.DataUltimaManutencao = monitoramento.DataUltimaManutencao;
                _dbContext.Monitoramento.Update(monitoramentos);
                await _dbContext.SaveChangesAsync();
            }
            return monitoramentos;

        }

        public async Task<bool> DeleteMonitoramento(int id)
        {
            MonitoramentoModel monitoramentos = await GetById(id);
            if (monitoramentos == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Monitoramento.Remove(monitoramentos);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}