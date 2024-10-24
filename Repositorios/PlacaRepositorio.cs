using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Api.Repositorios
{
    public class PlacaRepositorio : IPlacaRepositorio
    {
        private readonly Contexto _dbContext;

        public PlacaRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PlacaModel>> GetAll()
        {
            return await _dbContext.Placa.ToListAsync();
        }

        public async Task<PlacaModel> GetById(int id)
        {
            return await _dbContext.Placa.FirstOrDefaultAsync(x => x.PlacaId == id);
        }

        public async Task<PlacaModel> InsertPlaca(PlacaModel placa)
        {
            await _dbContext.Placa.AddAsync(placa);
            await _dbContext.SaveChangesAsync();
            return placa;
        }

        public async Task<PlacaModel> UpdatePlaca(PlacaModel placa, int id)
        {
            PlacaModel placas = await GetById(id);
            if (placas == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                placas.NomePlaca = placa.NomePlaca;
                placas.TipoPlacaId = placa.TipoPlacaId;
                placas.TamanhoPlaca = placa.TamanhoPlaca;
                _dbContext.Placa.Update(placas);
                await _dbContext.SaveChangesAsync();
            }
            return placas;

        }

        public async Task<bool> DeletePlaca(int id)
        {
            PlacaModel placas = await GetById(id);
            if (placas == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Placa.Remove(placas);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
