using Condominiosdotcom.Api.DTOs;
using Condominiosdotcom.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Interfaces
{
  public interface IClienteService: IService<Cliente>
    {
        IEnumerable<ReporteClienteDTO> GetReport(int id);
    }
}
