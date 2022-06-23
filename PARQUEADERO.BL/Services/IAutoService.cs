using PARQUEADERO.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO.BL.Services
{
    interface IAutoService : IGenericService<AUTO>
    {
        Task<bool> GetByPlaca(string placa);
        //Task<bool> DeleteCheckOnEntity(int id);
    }
}
