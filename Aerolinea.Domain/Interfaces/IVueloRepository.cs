using Aerolinea.Vuelo.Domain.Entities;
using Sharedkernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAerolinea.Vuelo.Domain.Interfaces
{
    public interface IVueloRepository: InterfaceGeneric<Vuelo,Guid>
    {
        Task UpdateAsync(Vuelo obj);

        Task RemoveAsync(Vuelo obj);
    }
}
