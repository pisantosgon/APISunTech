using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        [HttpGet("GetAllClientes")]
        public async Task<ActionResult<List<ClienteModel>>> GetAllClientes()
        {
            List<ClienteModel> cliente = await _clienteRepositorio.GetAll();
            return Ok(cliente);
        }

        [HttpGet("GetClienteId/{id}")]
        public async Task<ActionResult<ClienteModel>> GetClienteId(int id)
        {
            ClienteModel cliente = await _clienteRepositorio.GetById(id);
            return Ok(cliente);
        }

        [HttpPost("CreateCliente")]
        public async Task<ActionResult<ClienteModel>> InsertCliente([FromBody] ClienteModel clienteModel)
        {
            ClienteModel cliente = await _clienteRepositorio.InsertCliente(clienteModel);
            return Ok(cliente);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ClienteModel>> Login([FromBody] ClienteModel clienteModel)
        {
            ClienteModel cliente = await _clienteRepositorio.Login(clienteModel.EmailCliente, clienteModel.SenhaCliente );
            return Ok(cliente);
        }

    }
}
   
