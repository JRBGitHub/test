using DapperCoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCoreTest.Repositories.Stock
{
    public interface IBuscarReglas 
    {
        Task<List<Regla>> Execute();
    }
}
