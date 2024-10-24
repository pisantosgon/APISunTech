using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacaController : ControllerBase
    {
        private readonly IPlacaRepositorio _placaRepositorio;

        public PlacaController(IPlacaRepositorio placaRepositorio)
        {
            _placaRepositorio = placaRepositorio;
        }

        [HttpGet("GetAllPlacas")]
        public async Task<ActionResult<List<PlacaModel>>> GetAllPlacas()
        {
            List<PlacaModel> placas = await _placaRepositorio.GetAll();
            return Ok(placas);
        }

        [HttpGet("GetPlacaId/{id}")]
        public async Task<ActionResult<PlacaModel>> GetPlacaId(int id)
        {
            PlacaModel placa = await _placaRepositorio.GetById(id);
            return Ok(placa);
        }

        [HttpPost("CreatePlaca")]
        public async Task<ActionResult<PlacaModel>> InsertPlaca([FromBody] PlacaModel placaModel)
        {
            PlacaModel placa = await _placaRepositorio.InsertPlaca(placaModel);
            return Ok(placa);
        }
    }
}
