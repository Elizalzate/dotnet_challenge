using Application.Validators;
using AutoMapper;
using Core;
using Data;
using GestionClientesAPI.DTO;
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
        private readonly IMapper _mapper;

        public ClienteController(IContext data, ClienteRepository repo, IMapper mapper)
        {
            _data = data;
            _repo = repo;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> CreateClient(CreateClientDTO clienteDTO)
        {           
            var client = _mapper.Map<Cliente>(clienteDTO);
            _repo.CreateClient(client);
            return Created($"/api/cliente/{client.Documento}",client);
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
        public async Task<ActionResult<Cliente>> UpdateClient(Cliente cliente, string documento)
        {
            var client = _repo.UpdateClient(cliente, documento);
            return client == null ? NotFound("Cliente no encontrado") : Ok(client);
        }

        [HttpDelete("/{documento}")]
        public async Task<ActionResult<Cliente>> DeleteClient(string documento)
        {
            var client = _repo.DeleteClient(documento);
            return client == null ? NotFound("Cliente no encontrado") : Ok(client);
        }
    }
}