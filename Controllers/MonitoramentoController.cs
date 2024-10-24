using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitoramentoController : ControllerBase
    {
        private readonly IMonitoramentoRepositorio _monitoramentoRepositorio;

        public MonitoramentoController(IMonitoramentoRepositorio monitoramentoRepositorio)
        {
            _monitoramentoRepositorio = monitoramentoRepositorio;
        }

        [HttpGet("GetAllMonitoramentos")]
        public async Task<ActionResult<List<MonitoramentoModel>>> GetAllMonitoramentos()
        {
            List<MonitoramentoModel> monitoramentos = await _monitoramentoRepositorio.GetAll();
            return Ok(monitoramentos);
        }

        [HttpGet("GetMonitoramentoId/{id}")]
        public async Task<ActionResult<MonitoramentoModel>> GetMonitoramentoId(int id)
        {
            MonitoramentoModel monitoramento = await _monitoramentoRepositorio.GetById(id);
            return Ok(monitoramento);
        }

        [HttpPost("CreateMonitoramento")]
        public async Task<ActionResult<MonitoramentoModel>> InsertMonitoramento([FromBody] MonitoramentoModel monitoramentoModel)
        {
            MonitoramentoModel monitoramento = await _monitoramentoRepositorio.InsertMonitoramento(monitoramentoModel);
            return Ok(monitoramento);
        }
    }
}
