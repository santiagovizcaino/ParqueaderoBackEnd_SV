using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO.BL.DTOs
{
    public class LoginDTO
    {
        
        [Required]
        public string usuario { get; set; }

        [Required]
        public string password { get; set; }
        
        
    }
}
