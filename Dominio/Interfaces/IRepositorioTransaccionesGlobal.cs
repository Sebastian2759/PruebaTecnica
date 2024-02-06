using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepositorioTransaccionesGlobal
    {
        //Task<int> CrearInformacionGlobal(int clienteID, int concesionarioID);
        //Task<int> CrearClienteGlobal(string nombre, string email, string telefono, int informacionGlobalID);
        //Task<int> CrearConcesionarioGlobal(string nombre, string direccion, string ciudad, int informacionGlobalID);
        
        Task<TransaccionesGlobalEntidad> GetTransaccionesGlobal(int transaccionID);
        Task<List<TransaccionesGlobalEntidad>> GetTransaccionesGlobales();
        Task<bool> CrearTransaccionGlobal(TransaccionesGlobalEntidad entidad);
        Task<TransaccionesGlobalEntidad> ActualizarTransaccionesGlobal(TransaccionesGlobalEntidad entidad);
        Task<string> EliminarTransaccionesGlobal(int transaccionID);
    }
}
