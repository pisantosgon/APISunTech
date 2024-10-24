using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitoramentoDiarioController : ControllerBase
    {
        private readonly IMonitoramentoDiarioRepositorio _monitoramentodiarioRepositorio;

        public MonitoramentoDiarioController(IMonitoramentoDiarioRepositorio monitoramentodiarioRepositorio)
        {
            _monitoramentodiarioRepositorio = monitoramentodiarioRepositorio;
        }

        [HttpGet("GetAllMonitoramentosDiarios")]
        public async Task<ActionResult<List<MonitoramentoDiarioModel>>> GetAllMonitoramentosDiarios()
        {
            List<MonitoramentoDiarioModel> monitoramentosdiarios = await _monitoramentodiarioRepositorio.GetAll();
            return Ok(monitoramentosdiarios);
        }

        [HttpGet("GetMonitoramentoDiarioId/{id}")]
        public async Task<ActionResult<MonitoramentoDiarioModel>> GetMonitoramentoDiarioId(int id)
        {
            MonitoramentoDiarioModel monitoramentodiario = await _monitoramentodiarioRepositorio.GetById(id);
            return Ok(monitoramentodiario);
        }

        [HttpPost("CreateMonitoramentoDiario")]
        public async Task<ActionResult<MonitoramentoDiarioModel>> InsertMonitoramentoDiario([FromBody] MonitoramentoDiarioModel monitoramentodiarioModel)
        {
            MonitoramentoDiarioModel monitoramentodiario = await _monitoramentodiarioRepositorio.InsertMonitoramentoDiario(monitoramentodiarioModel);
            return Ok(monitoramentodiario);
        }
    }
}
