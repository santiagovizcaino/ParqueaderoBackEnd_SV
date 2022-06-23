using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARQUEADERO.BL.Models;

namespace PARQUEADERO.BL.Repositories
{
    public interface IAutoRepository : IGenericRepository<AUTO>
    {
        Task<bool> GetByPlaca(string placa);
        //Task<bool> DeleteCheckOnEntity(int id);
    }
}
