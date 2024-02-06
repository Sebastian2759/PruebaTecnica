using Aplication.Dto;
using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mapper.Interfaces
{
    public interface IMapperTransaccionesGlobal
    {
        List<TransaccionesGlobalDto> MapListTransaccionesGlobalDto(List<TransaccionesGlobalEntidad> transaccionesGlobalEntidad);
        TransaccionesGlobalDto MapTransaccionesGlobalDto(TransaccionesGlobalEntidad transaccionesGlobalEntidad);
        TransaccionesGlobalEntidad MapTransaccionesGlobalEntidad(TransaccionesGlobalDto dto);
    }
}
