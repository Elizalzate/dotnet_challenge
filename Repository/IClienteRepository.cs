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
        List<Cliente> CreateClient(Cliente client);
        List<Cliente> GetAll();
        Cliente? GetClient(string documento);
        Cliente? UpdateClient(Cliente client, string documento);
    }
}
