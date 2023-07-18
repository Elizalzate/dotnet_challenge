using Core;
using Data;
using Microsoft.EntityFrameworkCore.Storage;
using Repository.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly IContext _data;
    private readonly DatabaseGestion _db;

    public ClienteRepository(IContext data, DatabaseGestion db)
    {
        _data = data;
        _db = db;
    }

    public string CreateClient(Cliente client)
    {
        var cliente = _db.Cliente.SingleOrDefault(x => x.Documento == client.Documento);
        if (cliente == null)
        {
            _db.Cliente.Add(client);
            _db.SaveChanges();
            return "Cliente creado correctamente";
        }
        return "Cliente no pudo ser creado";
    }

    public string DeleteClient(string documento)
    {
        var cliente = _db.Cliente.SingleOrDefault(x =>x.Documento == documento);
        if(cliente != null)
        {
            _db.Cliente.Remove(cliente);
            _db.SaveChanges();
            return "cliente eliminado correctamente";
        }
        return "Cliente no encontrado";
    }

    public List<Cliente> GetAll()
    {
        var clientes = _db.Cliente;
        return clientes.ToList();
    }

    public Cliente? GetClient(string documento)
    {
        return _db.Cliente.SingleOrDefault(x => x.Documento == documento);
    }

    public List<Cliente> GetClientByCity(string ciudad)
    {
        return null;
        /*return _db.Cliente
            .Join(_db.ClienteDetalles, 
            ClienteKey => _db.Cliente.Documento,
            DetallesKey => _db.ClienteDetalles.Documento)*/
            
    
    }

    public string UpdateClient(Cliente cliente, string documento)
    {
        var client = _db.Cliente.SingleOrDefault(x => x.Documento == documento);
        if (client != null)
        {
            client.NombreCompleto = cliente.NombreCompleto;
            client.RazonSocial = cliente.RazonSocial;
            _db.SaveChanges();
            return "Información actualizada correctamente";
        }
        return "Cliente no encontrado";
    }

    
}
