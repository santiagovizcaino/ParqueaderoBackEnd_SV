using PARQUEADERO.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO.BL.Services
{
    public interface IUsuarioService:IGenericService<USUARIO>
    {
        Task<bool> GetUsuario(string usuario, string paswword);
    }
}
