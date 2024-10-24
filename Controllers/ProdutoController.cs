using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet("GetAllProdutos")]
        public async Task<ActionResult<List<ProdutoModel>>> GetAllProdutos()
        {
            List<ProdutoModel> produtos = await _produtoRepositorio.GetAll();
            return Ok(produtos);
        }

        [HttpGet("GetProdutoId/{id}")]
        public async Task<ActionResult<ProdutoModel>> GetProdutoId(int id)
        {
            ProdutoModel produto = await _produtoRepositorio.GetById(id);
            return Ok(produto);
        }

        [HttpPost("CreateProduto")]
        public async Task<ActionResult<ProdutoModel>> InsertProduto([FromBody] ProdutoModel produtoModel)
        {
            ProdutoModel produto = await _produtoRepositorio.InsertProduto(produtoModel);
            return Ok(produto);
        }
    }
}
