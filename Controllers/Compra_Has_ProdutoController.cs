using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Compra_Has_ProdutoController : ControllerBase
    {
        private readonly ICompra_Has_ProdutoRepositorio _compra_has_produtoRepositorio;

        public Compra_Has_ProdutoController(ICompra_Has_ProdutoRepositorio compra_has_produtoRepositorio)
        {
            _compra_has_produtoRepositorio = compra_has_produtoRepositorio;
        }

        [HttpGet("GetAllCompra_Has_Produtos")]
        public async Task<ActionResult<List<Compra_Has_ProdutoModel>>> GetAllCompra_Has_Produtos()
        {
            List<Compra_Has_ProdutoModel> compra_has_produtos = await _compra_has_produtoRepositorio.GetAll();
            return Ok(compra_has_produtos);
        }

        [HttpGet("GetCompra_Has_ProdutoId/{id}")]
        public async Task<ActionResult<Compra_Has_ProdutoModel>> GetCompra_Has_ProdutoId(int id)
        {
            Compra_Has_ProdutoModel compra_has_produto = await _compra_has_produtoRepositorio.GetById(id);
            return Ok(compra_has_produto);
        }

        [HttpPost("CreateCompra_Has_Produto")]
        public async Task<ActionResult<Compra_Has_ProdutoModel>> InsertCompra_Has_Produto([FromBody] Compra_Has_ProdutoModel compra_has_produtoModel)
        {
            Compra_Has_ProdutoModel compra_has_produto = await _compra_has_produtoRepositorio.InsertCompra_Has_Produto(compra_has_produtoModel);
            return Ok(compra_has_produto);
        }
    }
}

