using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitoramentoMensalController : ControllerBase
    {
        private readonly IMonitoramentoMensalRepositorio _monitoramentomensalRepositorio;

        public MonitoramentoMensalController(IMonitoramentoMensalRepositorio monitoramentomensalRepositorio)
        {
            _monitoramentomensalRepositorio = monitoramentomensalRepositorio;
        }

        [HttpGet("GetAllMonitoramentosMensais")]
        public async Task<ActionResult<List<MonitoramentoMensalModel>>> GetAllMonitoramentosMensais()
        {
            List<MonitoramentoMensalModel> monitoramentosmensais = await _monitoramentomensalRepositorio.GetAll();
            return Ok(monitoramentosmensais);
        }

        [HttpGet("GetMonitoramentoMensalId/{id}")]
        public async Task<ActionResult<MonitoramentoMensalModel>> GetMonitoramentoMensalId(int id)
        {
            MonitoramentoMensalModel monitoramentomensal = await _monitoramentomensalRepositorio.GetById(id);
            return Ok(monitoramentomensal);
        }

        [HttpPost("CreateMonitoramentoMensal")]
        public async Task<ActionResult<MonitoramentoMensalModel>> InsertMonitoramentoMensal([FromBody] MonitoramentoMensalModel monitoramentomensalModel)
        {
            MonitoramentoMensalModel monitoramentomensal = await _monitoramentomensalRepositorio.InsertMonitoramentoMensal(monitoramentomensalModel);
            return Ok(monitoramentomensal);
        }
    }
}
