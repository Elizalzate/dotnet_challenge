using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class SucursalDetalles
    {
        public string CodigoSucursal { get; set; }
        public string Direccion { get; set; } = String.Empty;
        public string Ciudad { get; set; } = String.Empty;
        public string Pais { get; set; } = "Colombia";
        public string TelefonoFijo { get; set; } = String.Empty;
        public string TelefonoCelular { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
    }
}
