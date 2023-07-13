using Core;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SucursalRepository : ISucursalRepository
    {
        private readonly IContext _data;

        public SucursalRepository(IContext data)
        {
            _data = data;
        }
        public List<Sucursal> CreateSucursal(Sucursal sucursal)
        {
            var sucursals = _data.Sucursales.SingleOrDefault(x => x.CodigoSucursal == sucursal.CodigoSucursal);
            if (sucursals == null)
            {
                _data.Sucursales.Add(sucursal);
            }
            return _data.Sucursales;
        }

        public List<Sucursal> DeleteSucursal(string codigo)
        {
            var sucursal = _data.Sucursales.SingleOrDefault(x => x.CodigoSucursal == codigo);
            if (sucursal != null)
            {
                _data.Sucursales.Remove(sucursal);
            }
            return _data.Sucursales;
        }

        public List<Sucursal> GetAll()
        {
            return _data.Sucursales;
        }

        public Sucursal? GetSucursal(string codigo)
        {
            var sucursal = _data.Sucursales.SingleOrDefault(x => x.CodigoSucursal == codigo);
            if (sucursal != null)
            {
                return sucursal;
            }
            return null;
        }

        public List<Sucursal> GetSucursalByCity(string ciudad)
        {
            return null;
            //var sucursales = _data.SucursalesDetalles.Where()
        }

        public Sucursal? UpdateSucursal(Sucursal sucursal, string codigo)
        {
            var sede = _data.Sucursales.SingleOrDefault(x => x.CodigoSucursal == codigo);
            if (sede != null)
            {
                _data.Sucursales.Remove(sucursal);
            }
            return sede;
        }
    }
}
