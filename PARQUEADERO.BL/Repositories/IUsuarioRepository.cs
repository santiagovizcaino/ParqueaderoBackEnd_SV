using PARQUEADERO.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO.BL.Repositories
{
    public interface IUsuarioRepository:IGenericRepository<USUARIO>
    {

        Task<bool> GetUsuario(string usuario,string paswword);
    }
}
