using Mercaderia.Entities;
using Mercaderia.Datos;
using Microsoft.AspNetCore.Mvc;

namespace Mercaderia.Controllers
{
    [ApiController]
    [Route("api/marca")]
    public class MarcaController : ControllerBase
    {
        
        //ALTA MARCA
        [HttpPost]
        public async Task Post([FromBody] Marca parametros)
        {
            var funcion = new DMarca();
            await funcion.AltaMarca(parametros);
        }


        //MODIFICACION MARCA
        [HttpPut("Modificacion_Marca/{id}")]
        public async Task<ActionResult> ModificacionMarca(int id, [FromBody] Marca parametros)
        {
            var funcion = new DMarca();
            parametros.Id = id;
            await funcion.ModificacionMarca(parametros);
            return NoContent();
        }


        //BAJA MARCA
        [HttpPut("Baja_Marca/{id}")]
        public async Task<ActionResult> BajaMarca(int id, [FromBody] Marca parametros)
        {
            var funcion = new DMarca();
            parametros.Id = id;
            await funcion.BajaMarca(parametros);
            return NoContent();
        }



    }
}
