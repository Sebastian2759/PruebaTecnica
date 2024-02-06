using Aplication.Dto;
using Aplication.Mapper.Interfaces;
using Aplication.Servicios.Interfaces;
using Dominio.Interfaces;
using Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Servicios
{
    public class ServicioTransaccionesGlobal : IServicioTransaccionesGlobal
    {
        private readonly IRepositorioTransaccionesGlobal _repositorioTransaccionesGlobal;
        private readonly IMapperTransaccionesGlobal _mapper;
        public ServicioTransaccionesGlobal(IRepositorioTransaccionesGlobal repositorioTransaccionesGlobal)
        {
            _repositorioTransaccionesGlobal = repositorioTransaccionesGlobal;
        }

        public async Task<TransaccionesGlobalDto> ActualizarTransaccionesGlobal(TransaccionesGlobalDto dto)
        {
            return _mapper.MapTransaccionesGlobalDto(await _repositorioTransaccionesGlobal.ActualizarTransaccionesGlobal(_mapper.MapTransaccionesGlobalEntidad(dto)));
        }

        public async Task<bool> CrearTransaccionGlobal(TransaccionesGlobalDto dto)
        {
            return await _repositorioTransaccionesGlobal.CrearTransaccionGlobal(_mapper.MapTransaccionesGlobalEntidad(dto));

        }

        public async Task<string> EliminarTransaccionesGlobal(int transaccionID)
        {
            return await _repositorioTransaccionesGlobal.EliminarTransaccionesGlobal(transaccionID);
        }

        public async Task<TransaccionesGlobalDto> GetTransaccionesGlobal(int transaccionID)
        {
            return _mapper.MapTransaccionesGlobalDto(await _repositorioTransaccionesGlobal.GetTransaccionesGlobal(transaccionID));
        }

        public async Task<List<TransaccionesGlobalDto>> GetTransaccionesGlobales()
        {
            return _mapper.MapListTransaccionesGlobalDto(await _repositorioTransaccionesGlobal.GetTransaccionesGlobales());
        }
    }
}
