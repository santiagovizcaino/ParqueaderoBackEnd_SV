using AutoMapper;
using PARQUEADERO.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO.BL.DTOs
{
    public class MapperConfig
    {
       
            public static MapperConfiguration MapperConfiguration()
            {
                return new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<AUTO, AutoDTO>(); //Get
                    cfg.CreateMap<AutoDTO, AUTO>(); //Post - Put -Patch

                    cfg.CreateMap<USUARIO, LoginDTO>(); //Get
                    cfg.CreateMap<LoginDTO, USUARIO>(); //Post - Put -Patch

                });
            }
        
    }
}
