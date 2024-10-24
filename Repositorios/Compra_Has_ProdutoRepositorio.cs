using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class Compra_Has_ProdutoRepositorio : ICompra_Has_ProdutoRepositorio
    {
        private readonly Contexto _dbContext;

        public Compra_Has_ProdutoRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Compra_Has_ProdutoModel>> GetAll()
        {
            return await _dbContext.Compra_Has_Produto.ToListAsync();
        }

        public async Task<Compra_Has_ProdutoModel> GetById(int id)
        {
            return await _dbContext.Compra_Has_Produto.FirstOrDefaultAsync(x => x.Compra_Has_ProdutoId == id);
        }

        public async Task<Compra_Has_ProdutoModel> InsertCompra_Has_Produto(Compra_Has_ProdutoModel compra_has_produto)
        {
            await _dbContext.Compra_Has_Produto.AddAsync(compra_has_produto);
            await _dbContext.SaveChangesAsync();
            return compra_has_produto;
        }

        public async Task<Compra_Has_ProdutoModel> UpdateCompra_Has_Produto(Compra_Has_ProdutoModel compra_has_produto, int id)
        {
            Compra_Has_ProdutoModel compra_has_produtos = await GetById(id);
            if (compra_has_produtos == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                compra_has_produtos.CompraId = compra_has_produto.CompraId;
                compra_has_produtos.ProdutoId = compra_has_produto.ProdutoId;
                compra_has_produtos.QuantidadeProduto = compra_has_produto.QuantidadeProduto;
                compra_has_produtos.ValorUnitario = compra_has_produto.ValorUnitario;
                compra_has_produtos.ValorTotalProduto = compra_has_produto.ValorTotalProduto;
                _dbContext.Compra_Has_Produto.Update(compra_has_produtos);
                await _dbContext.SaveChangesAsync();
            }
            return compra_has_produtos;

        }

        public async Task<bool> DeleteCompra_Has_Produto(int id)
        {
            Compra_Has_ProdutoModel compra_has_produtos = await GetById(id);
            if (compra_has_produtos == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Compra_Has_Produto.Remove(compra_has_produtos);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}