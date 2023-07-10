using Core;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly IContext _data;
    public List<Cliente> CreateClient(Cliente client)
    {
        throw new NotImplementedException();
    }

    public List<Cliente> GetAll()
    {
        return _data.Clientes.ToList();
    }

    public Cliente? GetClient(string documento)
    {
        return _data.Clientes.SingleOrDefault(x => x.Documento == documento);
    }

    public Cliente? UpdateClient(Cliente cliente, string documento)
    {
        var client = _data.Clientes.SingleOrDefault(x => x.Documento == documento);
        if (client != null)
        {
            client.NombreCompleto = cliente.NombreCompleto;
            client.TipoCliente = cliente.TipoCliente;
        }
        return client;
    }
}
