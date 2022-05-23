using Condominiosdotcom.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
   public interface ICuotaData
    {
        IEnumerable<Cuotas> GetCuota();
        Cuotas GetCuota(int id);
        Cuotas AddCuota(Cuotas newCuota);
        Cuotas ModifyCuota(Cuotas updateCuota);

        void DeleteCuota(int id);
    }
}
