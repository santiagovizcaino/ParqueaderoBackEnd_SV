using PARQUEADERO.BL.Data;
using PARQUEADERO.BL.Models;
using PARQUEADERO.BL.Repositories;
using System.Threading.Tasks;

namespace PARQUEADERO.BL.Services.Implements
{
    public class AutoService : GenericService<AUTO>,IAutoService
    {


        private readonly IAutoRepository autoRepository;
        public AutoService(IAutoRepository autoRepository) : base(autoRepository)
        {
            this.autoRepository = autoRepository;
        }

        public async Task<bool> GetByPlaca(string placa)
        {
            return await autoRepository.GetByPlaca(placa);
        }

        //public async Task<bool> DeleteCheckOnEntity(int id)
        //{
        //    return await autoRepository.DeleteCheckOnEntity(id);
        //}
    }
}
