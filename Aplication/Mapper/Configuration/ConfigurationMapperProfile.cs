using Aplication.Dto;
using AutoMapper;
using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mapper.Configuration
{
    public class ConfigurationMapperProfile:Profile
    {
      
        public ConfigurationMapperProfile()
        {
            CreateMap<InformacionGlobalEntidad, TransaccionesGlobalDto>()
                .ForMember(dest => dest.InformacionGlobalID, opt => opt.MapFrom(src => src.InformacionGlobalID))
                .ForMember(dest => dest.ClienteID, opt => opt.MapFrom(src => src.ClienteID))
                .ForMember(dest => dest.ConcesionarioID, opt => opt.MapFrom(src => src.ConcesionarioID))
                .ForMember(dest => dest.VehiculoID, opt => opt.MapFrom(src => src.VehiculoID))
                .ForMember(dest => dest.FechaVenta, opt => opt.MapFrom(src => src.FechaVenta))
                .ForMember(dest => dest.TransaccionID, opt => opt.MapFrom(src => src.TransaccionID))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta)).ReverseMap();
        }
    }
}
