using PARQUEADERO.BL.Data;
using PARQUEADERO.BL.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Entity;


namespace PARQUEADERO.BL.Repositories.Implements
{


    public class UsuarioRepository : GenericRepository<USUARIO>, IUsuarioRepository
    {
        private readonly ParqueaderoContext parqueaderoContext;
        public UsuarioRepository(ParqueaderoContext parqueaderoContext) : base(parqueaderoContext)
        {
            this.parqueaderoContext=parqueaderoContext;
        }

        public async Task<bool> GetUsuario(string usuario, string paswword)
        {
            var usuarioParameter = new SqlParameter("@usuario",usuario);
            var passwordParameter = new SqlParameter("@password", paswword);

            var result = await parqueaderoContext.Database.SqlQuery<USUARIO>
                ("login @usuario,@password", usuarioParameter, passwordParameter).FirstOrDefaultAsync(); ;
            if (result == null)
            {
                return false;
            }
            return true;
        }
    }
}
