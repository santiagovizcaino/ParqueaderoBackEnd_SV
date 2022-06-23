using PARQUEADERO.BL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO.BL.Data
{
    public class ParqueaderoContext : DbContext
    {
        public ParqueaderoContext():base("ParqueaderoContext")
        {

        }


        public DbSet<AUTO> Autos { get; set; }
        public DbSet<USUARIO> Usuarios { get; set; }

        public static ParqueaderoContext Create()
        {
            return new ParqueaderoContext();
        }
    }
}
