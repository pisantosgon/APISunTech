using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class TipoPlacaRepositorio : ITipoPlacaRepositorio
    {
        private readonly Contexto _dbContext;

        public TipoPlacaRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<TipoPlacaModel>> GetAll()
        {
            return await _dbContext.TipoPlaca.ToListAsync();
        }

        public async Task<TipoPlacaModel> GetById(int id)
        {
            return await _dbContext.TipoPlaca.FirstOrDefaultAsync(x => x.TipoPlacaId == id);
        }

        public async Task<TipoPlacaModel> InsertTipoPlaca(TipoPlacaModel tipoplaca)
        {
            await _dbContext.TipoPlaca.AddAsync(tipoplaca);
            await _dbContext.SaveChangesAsync();
            return tipoplaca;
        }

        public async Task<TipoPlacaModel> UpdateTipoPlaca(TipoPlacaModel tipoplaca, int id)
        {
            TipoPlacaModel tipoplacas = await GetById(id);
            if (tipoplacas == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                tipoplacas.NomeTipoPlaca = tipoplaca.NomeTipoPlaca;
                _dbContext.TipoPlaca.Update(tipoplacas);
                await _dbContext.SaveChangesAsync();
            }
            return tipoplacas;

        }

        public async Task<bool> DeleteTipoPlaca(int id)
        {
            TipoPlacaModel tipoplacas = await GetById(id);
            if (tipoplacas == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.TipoPlaca.Remove(tipoplacas);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}