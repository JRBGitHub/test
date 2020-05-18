using DapperCoreTest.Business;
using DapperCoreTest.Dtos;
using DapperCoreTest.Dtos.Stock;
using DapperCoreTest.Models;
using DapperCoreTest.Repositories;
using DapperCoreTest.Repositories.Interfaces;
using DapperCoreTest.Repositories.Stock;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace DapperCoreTest.BusinesStock
{
    public class OrquestaStock : IOrquestaStock
    {
        
        private readonly IBuscarReglas _reglas;
        private readonly IBuscarOperacionesCliente _buscarOperacionesCliente;
        public OrquestaStock( IBuscarReglas reglas, IBuscarOperacionesCliente buscarOperacionesCliente)
        {            
            _reglas = reglas;
            _buscarOperacionesCliente = buscarOperacionesCliente;
        }

        public async Task<responseDto> PuedoOperarCVME(string identificacion)
        {
            List<Operacion> operaciones= new List<Operacion>();

            List<Regla> reglas = await _reglas.Execute();


            //si tiene operacion ejecutada que cumpla con una 1regla ?puede Operar? o se tienen que cumplir todas?
            foreach (var item in reglas)
            {
                operaciones.AddRange(await _buscarOperacionesCliente.Execute(identificacion));                
            }


           var resultado=  await Task.Run(() => {
                if (operaciones.Count > 1)
                {
                    var dtoNotOk = new responseDto()
                    {
                        puedeOperar = false,
                        resultadoDeOperacion ="Posee prestamos tasa 0"

                    };
                   return dtoNotOk;

               }
               else
               {
                   var dtoOK = new responseDto()
                   {
                       puedeOperar = true,
                       resultadoDeOperacion = "Puede Operar"

                   };
                   return dtoOK;
               }
           });

            return resultado;
        }
    }
}
