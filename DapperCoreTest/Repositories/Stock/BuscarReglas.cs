using DapperCoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCoreTest.Repositories.Stock
{
    public class BuscarReglas : IBuscarReglas
    {
        public async Task<List<Regla>> Execute()
        {

            var result = await Task.Run(() => {

                List<Regla> operaciones = new List<Regla>()
                 {
                     new Regla()
                     {
                         codigo="1",
                         descripcion="NO DEBE POSEER PRESTAMOS TASA 0"
                     },
                   
                  };
                return operaciones;
            });

            return result;

        }
    }
}
