using PARQUEADERO.BL.Data;
using PARQUEADERO.BL.Models;
using System.Threading.Tasks;
using System.Data.Entity;


namespace PARQUEADERO.BL.Repositories.Implements
{
    public class AutoRepository: GenericRepository<AUTO>,IAutoRepository
    {
        private readonly ParqueaderoContext parqueaderoContext;
        public AutoRepository(ParqueaderoContext parqueaderoContext):base(parqueaderoContext)
        {
            this.parqueaderoContext = parqueaderoContext;
        }

        public async Task<bool> GetByPlaca(string placa)
        {
            var control = await parqueaderoContext.Set<AUTO>().AnyAsync(x => x.placa == placa);
            return control;
        }

        //public async Task<bool> DeleteCheckOnEntity(int id)
        //{
        //    var control = await parqueaderoContext.Tiket.AnyAsync(x => x.CourseID == id);
        //    return true;
        //}
    }
}
