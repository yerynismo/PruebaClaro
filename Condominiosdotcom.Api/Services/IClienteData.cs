using Condominiosdotcom.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
  public interface IClienteData
    {
        List<Cliente> GetClient();
        Cliente GetClient(int id);
        Cliente AddClient(Cliente newClient);
        Cliente ModifyClient(Cliente updateClient);

        void DeleteClient(int id);

    }
}
