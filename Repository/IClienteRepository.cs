using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IClienteRepository
    {
        string CreateClient(Cliente client);
        List<Cliente> GetAll();
        Cliente? GetClient(string documento);
        List<Cliente> GetClientByCity(string ciudad);
        string UpdateClient(Cliente client, string documento);

        string DeleteClient(string documento);

    }
}
