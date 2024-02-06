using Aplication.Dto;
using Aplication.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Infraestructure.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionesGlobalController : ControllerBase
    {
        private readonly IServicioTransaccionesGlobal _servicioTransaccionesGlobal;
        public TransaccionesGlobalController(IServicioTransaccionesGlobal servicioTransaccionesGlobal)
        {
            _servicioTransaccionesGlobal = servicioTransaccionesGlobal;
        }
        // GET: api/<TransaccionesGlobalController>
        [HttpGet]
        public async Task<List<TransaccionesGlobalDto>> Get()
        {
            return await _servicioTransaccionesGlobal.GetTransaccionesGlobales();
        }

        // GET api/<TransaccionesGlobalController>/5
        [HttpGet("{id}")]
        public async Task<TransaccionesGlobalDto> Get(int id)
        {
            return await _servicioTransaccionesGlobal.GetTransaccionesGlobal(id);
        }

        // POST api/<TransaccionesGlobalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<TransaccionesGlobalController>/5
        [HttpPut("{id}")]
        public TransaccionesGlobalDto Put([FromBody] TransaccionesGlobalDto id)
        {
            return  _servicioTransaccionesGlobal.ActualizarTransaccionesGlobal(id).Result;
        }

        // DELETE api/<TransaccionesGlobalController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await _servicioTransaccionesGlobal.EliminarTransaccionesGlobal(id);  
        }
    }
}
