using Core;
using Data;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace GestionClientesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IContext _data;
        private readonly ClienteRepository _repo;

        public ClienteController(IContext data, ClienteRepository repo)
        {
            _data = data;
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<Cliente>> GetClients()
        {
            var clients = _repo.GetAll();
            var clientsInfo = _data.ClientesDetalles.ToList();
            return clients == null ? NotFound("Clientes no encontrados.") : Ok(clients);
        }

        [HttpGet("/{documento}")]
        public async Task<ActionResult<Cliente>> GetClient(string documento)
        {
            var client = _repo.GetClient(documento);
            return client == null ? NotFound("Cliente no encontrado.") : Ok(client);
        }

        [HttpPut("/{documento}")]
        public async Task<ActionResult<Cliente>> UpdateCliente(Cliente cliente, string documento)
        {
            var client = _repo.UpdateClient(cliente, documento);
            return client == null ? NotFound("Cliente no encontrado") : Ok(client);
        }
    }
}