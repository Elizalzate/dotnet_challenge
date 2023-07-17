using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core;

public class Sucursal
{
    public string CodigoSucursal { get; set; } = String.Empty;
    public string NombreSucursal { get; set; } = String.Empty;
    public string CodigoVendedor { get; set; } = String.Empty;
    public double CupoCredito { get; set; } 

    public SucursalDetalles SucursalDetalles { get; set; }
}
