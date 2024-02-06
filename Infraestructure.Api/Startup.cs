using Aplication.Mapper;
using Aplication.Mapper.Configuration;
using Aplication.Mapper.Interfaces;
using Aplication.Servicios;
using Aplication.Servicios.Interfaces;
using AutoMapper;
using Dominio.Interfaces;
using Infraestructure.Data.Context;
using Infraestructure.Data.Context.Configuration;
using Infraestructure.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infraestructure.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<VentasVehiculosContext>(option =>
            {
                option.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            });
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            services.AddSingleton(new ConfigurationDbContext(connectionString));

            // Add services to the container.


            //Services del proyecto
            services.AddSingleton(new ConfigurationDbContext(connectionString));
            services.AddSingleton<IRepositorioTransaccionesGlobal, RepositorioTransaccionesGlobal>();
            services.AddSingleton<IServicioTransaccionesGlobal, ServicioTransaccionesGlobal>();
            services.AddSingleton<IMapperTransaccionesGlobal, MapperTransaccionesGlobal>();
            services.AddSingleton<IMapper>(new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<ConfigurationMapperProfile>())));   
        }

    }
}
