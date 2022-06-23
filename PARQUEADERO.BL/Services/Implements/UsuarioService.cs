using PARQUEADERO.BL.Models;
using PARQUEADERO.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO.BL.Services.Implements
{
    public class UsuarioService: GenericService<USUARIO>, IUsuarioService
    {


        private readonly IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }


        public async Task<bool> GetUsuario(string usuario, string paswword)
        {
            return await usuarioRepository.GetUsuario(usuario, paswword);
        }







    }
}
