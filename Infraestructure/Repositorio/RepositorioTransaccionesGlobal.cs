using Dominio.Entidades.VentasVehiculos;
using Dominio.Interfaces;
using Infraestructure.Data.Context;
using Infraestructure.Data.Context.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Infraestructure.Repositorio
{
    public class RepositorioTransaccionesGlobal : IRepositorioTransaccionesGlobal
    {
        private readonly ConfigurationDbContext _ConfigurationDbContext;
        public async Task<TransaccionesGlobalEntidad> ActualizarTransaccionesGlobal(TransaccionesGlobalEntidad entidad)
        {
            TransaccionesGlobalEntidad transaccionesGlobalEntidad = new TransaccionesGlobalEntidad();
            try
            {
                using (var db = GetVentasVehiculosContext())
                {
                    var busqueda = db.TransaccionesGlobal.Where(x => x.TransaccionID == entidad.TransaccionID).FirstOrDefault();
                    if (busqueda.Equals(null))
                    {

                        transaccionesGlobalEntidad.ClienteID = entidad.ClienteID;
                        transaccionesGlobalEntidad.ConcesionarioID = entidad.ConcesionarioID;
                        transaccionesGlobalEntidad.FechaVenta = entidad.FechaVenta;
                        transaccionesGlobalEntidad.InformacionGlobalID = entidad.InformacionGlobalID;
                        transaccionesGlobalEntidad.PrecioVenta = entidad.PrecioVenta;
                        transaccionesGlobalEntidad.VehiculoID = entidad.VehiculoID;
                        db.TransaccionesGlobal.Add(transaccionesGlobalEntidad);
                        await db.SaveChangesAsync();
                        return transaccionesGlobalEntidad;

                    }
                    else
                    {
                        return new TransaccionesGlobalEntidad();
                    }
                }
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
           
        }


        public Task<bool> CrearTransaccionGlobal(TransaccionesGlobalEntidad entidad)
        {
            using (var db = GetVentasVehiculosContext())
            {
                db.TransaccionesGlobal.Add(entidad);
                db.SaveChangesAsync();
                return Task.FromResult(true);
            }
        }

        public Task<string> EliminarTransaccionesGlobal(int transaccionID)
        {
            using (var db = GetVentasVehiculosContext())
            {
                var busqueda = db.TransaccionesGlobal.Where(x => x.TransaccionID == transaccionID).FirstOrDefaultAsync();
                if (!busqueda.Equals(null))
                {
                    db.TransaccionesGlobal.Remove(busqueda.Result);
                    db.SaveChangesAsync();
                    return Task.FromResult("Se actualizo Correctamente");
                }
                else
                { 
                    return Task.FromResult("No Se actualizo Correctamente");
                }
            }
        }

        public async Task<TransaccionesGlobalEntidad> GetTransaccionesGlobal(int transaccionID)
        {
            try
            {
                using (var db = GetVentasVehiculosContext())
                {
                    var result = db.TransaccionesGlobal.Where(x => x.TransaccionID == transaccionID).FirstOrDefaultAsync();
                    if (!result.Result.Equals(null))
                    {
                        return await result;
                    }
                    else
                    {
                        return null;
                    }
                  
                }
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
           
        }

        public Task<List<TransaccionesGlobalEntidad>> GetTransaccionesGlobales()
        {
            try
            {
                using (var db = GetVentasVehiculosContext())
                {
                    return db.TransaccionesGlobal.ToListAsync();
                }
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }

        }
        public VentasVehiculosContext GetVentasVehiculosContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<VentasVehiculosContext>();
            string connection = _ConfigurationDbContext.ConnectionString;
            optionsBuilder.UseSqlServer(_ConfigurationDbContext.ConnectionString);
            return new VentasVehiculosContext(optionsBuilder.Options);

        }
    }
}
