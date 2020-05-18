using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperCoreTest.Business;
using DapperCoreTest.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperCoreTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrquestadorCVMEController : ControllerBase
    {
        private readonly IOrquestaStock _orquestaStock;
        public OrquestadorCVMEController(IOrquestaStock orquestaStock)
        {
            _orquestaStock = orquestaStock;

        }
        // GET: api/OrquestadorCVME
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            responseDto resultado = await _orquestaStock.PuedoOperarCVME("1");
            
            return new string[] { resultado.puedeOperar.ToString(), resultado.resultadoDeOperacion };
        }

        // GET: api/OrquestadorCVME/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OrquestadorCVME
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/OrquestadorCVME/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
