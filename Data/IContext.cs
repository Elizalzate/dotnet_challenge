using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data;

public interface IContext
{
    public List<Cliente> Clientes { set; get; }
    public List<ClienteDetalles> ClientesDetalles { get; set; }

    public List<Sucursal> Sucursales { set; get; }
    public List<SucursalDetalles> SucursalesDetalles { set; get; }

}
