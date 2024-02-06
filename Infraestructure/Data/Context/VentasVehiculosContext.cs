using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades.VentasVehiculos;
namespace Infraestructure.Data.Context
{
    public class VentasVehiculosContext:DbContext
    {
        public VentasVehiculosContext(DbContextOptions<VentasVehiculosContext> options):base(options)
        {

        }
        public DbSet<InformacionGlobalEntidad> GlobalEntidad { get; set;}
        public DbSet<ClientesGlobalEntidad> ClientesGlobalEntidad { get; set; }
        public DbSet<ConcesionariosGlobal> ConcesionariosGlobal { get; set; }
        public DbSet<TransaccionesGlobalEntidad> TransaccionesGlobal { get; set; }


    }
}
