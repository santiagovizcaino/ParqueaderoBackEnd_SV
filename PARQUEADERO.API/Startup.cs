using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using PARQUEADERO.BL.Data;

[assembly: OwinStartup(typeof(PARQUEADERO.API.Startup))]

namespace PARQUEADERO.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(ParqueaderoContext.Create);
        }
    }
}
