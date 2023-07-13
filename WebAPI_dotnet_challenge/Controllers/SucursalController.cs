using Core;
using Data;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace GestionSucursalsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SucursalController : ControllerBase
    {
        private readonly IContext _data;
        private readonly SucursalRepository _repo;

        public SucursalController(IContext data, SucursalRepository repo)
        {
            _data = data;
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<Sucursal>> GetSucursals()
        {
            var Sucursals = _repo.GetAll();
            //var SucursalsInfo = _data.SucursalsDetalles.ToList();
            return Sucursals == null ? NotFound("Sucursals no encontrados.") : Ok(Sucursals);
        }

        [HttpGet("/{codigo}")]
        public async Task<ActionResult<Sucursal>> GetSucursal(string codigo)
        {
            var Sucursal = _repo.GetSucursal(codigo);
            return Sucursal == null ? NotFound("Sucursal no encontrado.") : Ok(Sucursal);
        }

        [HttpPut("/{codigo}")]
        public async Task<ActionResult<Sucursal>> UpdateSucursal(Sucursal Sucursal, string codigo)
        {
            var Sucursa = _repo.UpdateSucursal(Sucursal, codigo);
            return Sucursal == null ? NotFound("Sucursal no encontrado") : Ok(Sucursal);
        }

        [HttpDelete("/{codigo}")]
        public async Task<ActionResult<Sucursal>> DeleteSucursal(string codigo)
        {
            var Sucursal = _repo.DeleteSucursal(codigo);
            return Sucursal == null ? NotFound("Sucursal no encontrado") : Ok(Sucursal);
        }
    }
}