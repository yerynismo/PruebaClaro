using Condominiosdotcom.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
  public  interface IPagosData
    {

        IEnumerable<Pagos> GetPagos();
        Pagos GetPagos(int id);
        Pagos AddPagos(Pagos newPagos);
        Pagos ModifyPagos(Pagos updatePagos);

        void DeletePagos(int id);
    }
}
