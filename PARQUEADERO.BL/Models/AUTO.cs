using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO.BL.Models
{
    [Table("AUTO", Schema = "dbo")]
    public class AUTO
    {
        [Key]
        public int id { get; set; }
        public string placa { get; set; }
        public DateTime hora_ingreso { get; set; }
        public Nullable<DateTime> hora_salida { get; set; }
        public Decimal pago { get; set; }
    }
}
