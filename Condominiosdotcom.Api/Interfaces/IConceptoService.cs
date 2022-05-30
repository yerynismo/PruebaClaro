using Condominiosdotcom.Api.Models;
using System.Collections.Generic;

namespace Condominiosdotcom.Api.Interfaces
{
    public interface IConceptoService : IService<Concepto>
    {
        IEnumerable<Concepto> Get(bool? isRecurrente);
    }
}
