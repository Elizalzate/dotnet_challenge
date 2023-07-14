using Core;
namespace Data;
public class Context : IContext
{
    public List<Cliente> Clientes { get; set; }
    public List<ClienteDetalles> ClientesDetalles { get; set; }
    public List<Sucursal> Sucursales { get; set; }
    public List<SucursalDetalles> SucursalesDetalles { get; set; }

    public Context()
    {
        Clientes = new List<Cliente>
        {
            new Cliente {
                IdTipoCliente = 1,
                IdTipoDocumento = 1,
                Documento = "1033523258",
                NombreCompleto = "Toribio Pérez"
            },
            new Cliente {
                IdTipoCliente = 1,
                IdTipoDocumento = 1,
                Documento = "123",
                NombreCompleto = "prueba"
            }
        };

        ClientesDetalles = new List<ClienteDetalles>
        {
            new ClienteDetalles{
                Documento = "123",
                Ciudad = "Medellín",
                Pais = "Colombia",
                Email = "prueba@email.com",
                TelefonoCelular = "3006002223"

            }
        };
    }
}
