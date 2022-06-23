using PARQUEADERO.BL.Data;
using PARQUEADERO.BL.DTOs;
using PARQUEADERO.BL.Repositories.Implements;
using PARQUEADERO.BL.Services.Implements;
using System.Threading.Tasks;
using System.Web.Http;


namespace PARQUEADERO.API.Controllers
{
    [AllowAnonymous]
    public class AccountController : ApiController
    {

        private readonly UsuarioService usuarioService = new UsuarioService(new UsuarioRepository(ParqueaderoContext.Create()));
        /// <summary>
        /// metodo encargado de realizar la autenticacion
        /// </summary>
        /// <param name="loginDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IHttpActionResult> Login(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
          
            var userExist = await usuarioService.GetUsuario(loginDTO.usuario, loginDTO.password);
            if (userExist)
            {
                var token = TokenGenerator.GenerateTokenJwt(loginDTO.usuario);
                return Ok(token);
            }
            else
                return Unauthorized();

           

        }
    }
}
