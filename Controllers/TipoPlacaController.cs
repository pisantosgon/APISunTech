using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPlacaController : ControllerBase
    {
        private readonly ITipoPlacaRepositorio _tipoplacaRepositorio;

        public TipoPlacaController(ITipoPlacaRepositorio tipoplacaRepositorio)
        {
            _tipoplacaRepositorio = tipoplacaRepositorio;
        }

        [HttpGet("GetAllTipoPlaca")]
        public async Task<ActionResult<List<TipoPlacaModel>>> GetAllTipoPlacas()
        {
            List<TipoPlacaModel> tipoplacas = await _tipoplacaRepositorio.GetAll();
            return Ok(tipoplacas);
        }

        [HttpGet("GetTipoPlacaId/{id}")]
        public async Task<ActionResult<TipoPlacaModel>> GetTipoPlacaId(int id)
        {
            TipoPlacaModel tipoplaca = await _tipoplacaRepositorio.GetById(id);
            return Ok(tipoplaca);
        }

        [HttpPost("CreateTipoPlaca")]
        public async Task<ActionResult<TipoPlacaModel>> InsertTipoPlaca([FromBody] TipoPlacaModel tipoplacaModel)
        {
            TipoPlacaModel tipoplaca = await _tipoplacaRepositorio.InsertTipoPlaca(tipoplacaModel);
            return Ok(tipoplaca);
        }
    }
}
