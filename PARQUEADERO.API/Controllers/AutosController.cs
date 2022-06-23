using AutoMapper;
using PARQUEADERO.BL.Data;
using PARQUEADERO.BL.DTOs;
using PARQUEADERO.BL.Models;
using PARQUEADERO.BL.Repositories.Implements;
using PARQUEADERO.BL.Services.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PagedList;

namespace PARQUEADERO.API.Controllers
{
    public class AutosController : ApiController
    {
        private IMapper mapper;
        private readonly AutoService autoService = new AutoService(new AutoRepository(ParqueaderoContext.Create()));
        public AutosController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        /// <summary>
        /// Obtiene los autos dentro del parqueadero con paginacion
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <returns>OK. Devuelve el listado de los Autos en el parqueadero</returns>
        [HttpGet]
        [ResponseType(typeof(IEnumerable<AutoDTO>))]
        public async Task<IHttpActionResult> GetAll(int? pageSize,int?page)
        {
            var autos = await autoService.GetAll();
            var autosDTO = autos.Where(x => x.hora_salida == null). Select(x => mapper.Map<AutoDTO>(x));

            pageSize = (pageSize ?? 5);
            page = (page ?? 1);
            

            return Ok(autosDTO.ToPagedList(page.Value,pageSize.Value));
        }

        /// <summary>
        /// Obtiene un auto por su ID
        /// </summary>
        /// <param name="id">id del objeto</param>
        /// <returns>Objeto de tipo COurse</returns>
        /// <response code="200">OK. Devuelve el objeto solicitado</response>
        ///  <response code="404">NotFound. No se encuentra el los objetos solicitados</response>
        [HttpGet]
        [ResponseType(typeof(AutoDTO))]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var auto = await autoService.GetById(id);
            if (auto == null)
                return NotFound();

            var courseDTO = mapper.Map<AutoDTO>(auto);

            return Ok(courseDTO);
        }
        /// <summary>
        /// Ingresa un vehiculo al parqueadero
        /// </summary>
        /// <param name="autoDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IHttpActionResult> Post([FromBody] AutoDTO autoDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {

                var auto = mapper.Map<AUTO>(autoDTO);
                auto = await autoService.Insert(auto);
                return Ok(auto);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        /// <summary>
        /// Metodo para el control de salida del vehiculo
        /// </summary>
        /// <param name="autoDTO"></param>
        /// <param name="id"></param>
        /// <returns>retorna el valor a pagar</returns>
        [HttpPut]
        [Authorize]
        public async Task<IHttpActionResult> Put(AutoDTO autoDTO, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            autoDTO.id = id;
            var cuota = 1;
            var control = await autoService.GetByPlaca(autoDTO.placa);
            if (!control)
                return NotFound();

            autoDTO.hora_salida= DateTime.Now;

            var tiempo = (autoDTO.hora_salida - autoDTO.hora_ingreso).Value;
            var horas = tiempo.Hours;
            var minutos = tiempo.Minutes;
            if (minutos > 0) 
                horas += 1;

            autoDTO.pago = horas * cuota;

            try
            {
                var auto = mapper.Map<AUTO>(autoDTO);
                auto = await autoService.Update(auto);
                return Ok(auto.pago);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }


        /// <summary>
        /// elimina un registro de la tabla auto en la base parqueadero_SV
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Authorize]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var control = await autoService.GetById(id);
            if (control == null)
                return NotFound();

            try
            {

                await autoService.Delete(id);
                return Ok();

            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }
    }
}
