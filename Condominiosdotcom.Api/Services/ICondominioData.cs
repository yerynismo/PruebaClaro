using Condominiosdotcom.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
   public interface ICondominioData
    {
        IEnumerable<Condominio> GetCondominio();
        Condominio GetCondominio(int id);
        Condominio AddCondominio(Condominio newCondominio);
        Condominio ModifyCondominio(Condominio updateCondominio);

        void DeleteCondominio(int id);

    }
}
