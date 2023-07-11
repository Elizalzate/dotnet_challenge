using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ISucursalRepository
    {
        List<Sucursal> CreateSucursal(Sucursal sucursal);
        List<Sucursal> GetAll();
        Sucursal? GetSucursal(string codigo);
        Sucursal? UpdateClient(Cliente client, string documento);
    }
}
