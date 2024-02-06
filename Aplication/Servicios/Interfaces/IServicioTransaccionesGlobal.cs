using Aplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Servicios.Interfaces
{
    public interface IServicioTransaccionesGlobal
    {
        Task<TransaccionesGlobalDto> GetTransaccionesGlobal(int transaccionID);
        Task<List<TransaccionesGlobalDto>> GetTransaccionesGlobales();
        Task<TransaccionesGlobalDto> ActualizarTransaccionesGlobal(TransaccionesGlobalDto entidad);
        Task<string> EliminarTransaccionesGlobal(int transaccionID);
        Task<bool> CrearTransaccionGlobal(TransaccionesGlobalDto dto);
    }
}
