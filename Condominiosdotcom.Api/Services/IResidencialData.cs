using Condominiosdotcom.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
     public interface IResidencialData
    {
        IEnumerable<Residencial> GetResidencial();
        Residencial GetResidencial(int id);
        Residencial AddResidencial(Residencial newResidencial);
        Residencial ModifyResidencial(Residencial updateResidencial);

        void DeleteResidencial(int id);

    }
}
