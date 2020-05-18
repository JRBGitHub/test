using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCoreTest.Repositories.Interfaces
{
    public interface IBuscarOperacionesCliente
    {
        Task<List<Operacion>> Execute(string identificacion);

    }
}
