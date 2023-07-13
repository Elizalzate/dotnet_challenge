using Core;
using Data;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly IContext _data;

    public ClienteRepository(IContext data)
    {
        _data = data;
    }

    public List<Cliente> CreateClient(Cliente client)
    {
        var cliente = _data.Clientes.SingleOrDefault(x => x.Documento == client.Documento);
        if (cliente == null)
        {
            client.NombreCompleto = cliente.NombreCompleto;
            client.TipoCliente = cliente.TipoCliente;
        }
        return _data.Clientes;
    }

    public List<Cliente> DeleteClient(string documento)
    {
        var cliente = _data.Clientes.SingleOrDefault(x =>x.Documento == documento);
        if(cliente != null)
        {
            _data.Clientes.Remove(cliente);
        }
        return _data.Clientes;
    }

    public List<Cliente> GetAll()
    {
       /* var clientes = db.Blogs
            .OrderBy(b => b.BlogId)
            .First();*/
        return _data.Clientes.ToList();
    }

    public Cliente? GetClient(string documento)
    {
        return _data.Clientes.SingleOrDefault(x => x.Documento == documento);
    }

    public List<Cliente> GetClientByCity(string ciudad)
    {
        throw new NotImplementedException();
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
