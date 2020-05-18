using DapperCoreTest.Repositories.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DapperCoreTest.Repositories
{
    public class BuscarOperacionesCliente :IBuscarOperacionesCliente
    {
        public async Task<List<Operacion>> Execute(string identificacion)
        {
           
            var result = await Task.Run(() => {
              
                List<Operacion> operaciones = new List<Operacion>()
                 {
                     new Operacion()
                     {
                         idOperacion = "2"
                     },
                     new Operacion()
                     {
                         idOperacion = "2"
                     }
                  };
                return operaciones;
            });

            return result;


        }
    }

    public class Operacion
    {
        public string idOperacion { get; set; }
    }
}
