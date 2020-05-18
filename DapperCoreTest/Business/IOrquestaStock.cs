using DapperCoreTest.Dtos;
using DapperCoreTest.Dtos.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCoreTest.Business
{
    public interface IOrquestaStock
    {
        Task<responseDto> PuedoOperarCVME(string responseDto);
    }
}
