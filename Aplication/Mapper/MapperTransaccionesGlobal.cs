using Aplication.Dto;
using Aplication.Mapper.Configuration;
using Aplication.Mapper.Interfaces;
using AutoMapper;
using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mapper
{
    public class MapperTransaccionesGlobal: IMapperTransaccionesGlobal
    {
        private readonly IMapper mapper;

        public MapperTransaccionesGlobal(IMapper mapper)
        {
            var confi = new MapperConfiguration(cfg => cfg.AddProfile<ConfigurationMapperProfile>());
            this.mapper = mapper;
        }

        public List<TransaccionesGlobalDto> MapListTransaccionesGlobalDto(List<TransaccionesGlobalEntidad> transaccionesGlobalEntidad)
        {
            return mapper.Map<List<TransaccionesGlobalDto>>(transaccionesGlobalEntidad);
        }
        public TransaccionesGlobalDto MapTransaccionesGlobalDto(TransaccionesGlobalEntidad transaccionesGlobalEntidad)
        {
            return mapper.Map<TransaccionesGlobalDto>(transaccionesGlobalEntidad);
        }
        public TransaccionesGlobalEntidad MapTransaccionesGlobalEntidad(TransaccionesGlobalDto dto)
        {
            return mapper.Map<TransaccionesGlobalEntidad>(dto);
        }
    }
}
