using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly ICompraRepositorio _compraRepositorio;

        public CompraController(ICompraRepositorio compraRepositorio)
        {
            _compraRepositorio = compraRepositorio;
        }

        [HttpGet("GetAllCompras")]
        public async Task<ActionResult<List<CompraModel>>> GetAllCompras()
        {
            List<CompraModel> compras = await _compraRepositorio.GetAll();
            return Ok(compras);
        }

        [HttpGet("GetCompraId/{id}")]
        public async Task<ActionResult<CompraModel>> GetCompraId(int id)
        {
            CompraModel compra = await _compraRepositorio.GetById(id);
            return Ok(compra);
        }

        [HttpPost("CreateCompra")]
        public async Task<ActionResult<CompraModel>> InsertCompra([FromBody] CompraModel compraModel)
        {
            CompraModel compra = await _compraRepositorio.InsertCompra(compraModel);
            return Ok(compra);
        }
    }
}
