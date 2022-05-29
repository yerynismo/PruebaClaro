using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Interfaces
{
    public interface IService<T>
    {

        IEnumerable<T> Get();
        T Get(int id);
        
        T Add(T _object);
        T Modify(T _object);
        void Delete(int id);

    }

}
