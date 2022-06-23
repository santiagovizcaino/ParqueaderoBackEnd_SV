using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PARQUEADERO.BL.DTOs
{
    public class AutoDTO
    {

        public int id { get; set; }
        [Required(ErrorMessage ="La placa del vehiculo es obligatoria")]
        public string placa { get; set; }
        [Required(ErrorMessage = "La hora de ingreso del vehiculo es obligatoria")]
        public DateTime hora_ingreso { get; set; }
        [Column(TypeName = "datetime2")]
        public Nullable<DateTime> hora_salida { get; set; }
        public Decimal pago { get; set; }
    }
}
