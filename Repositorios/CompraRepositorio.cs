using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class CompraRepositorio : ICompraRepositorio
    {
        private readonly Contexto _dbContext;

        public CompraRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CompraModel>> GetAll()
        {
            return await _dbContext.Compra.ToListAsync();
        }

        public async Task<CompraModel> GetById(int id)
        {
            return await _dbContext.Compra.FirstOrDefaultAsync(x => x.CompraId == id);
        }

        public async Task<CompraModel> InsertCompra(CompraModel compra)
        {
            await _dbContext.Compra.AddAsync(compra);
            await _dbContext.SaveChangesAsync();
            return compra;
        }

        public async Task<CompraModel> UpdateCompra(CompraModel compra, int id)
        {
            CompraModel compras = await GetById(id);
            if (compras == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                compras.CompraId = compra.CompraId;
                compras.ClienteId = compra.ClienteId;
                compras.TotalCompra = compra.TotalCompra;
                await _dbContext.SaveChangesAsync();
            }
            return compras;

        }

        public async Task<bool> DeleteCompra(int id)
        {
            CompraModel compras = await GetById(id);
            if (compras == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Compra.Remove(compras);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
