using Mercaderia.Entities;
using Mercaderia.Datos;
using Microsoft.AspNetCore.Mvc;

namespace Mercaderia.Controllers
{
    [ApiController]
    [Route("api/familia")]
    public class FamiliaController : ControllerBase
    {
        //ALTA FAMILIA
        [HttpPost]
        public async Task Post([FromBody] Familia parametros)
        {
            var funcion = new DFamilia();
            await funcion.AltaFamilia(parametros);
        }


        //MODIFICACION FAMILIA
        [HttpPut("Modifiacion_Familia/{id}")]
        public async Task<ActionResult> ModificacionFamilia(int id, [FromBody] Familia parametros)
        {
            var funcion = new DFamilia();
            parametros.Id = id;
            await funcion.ModificacionFamilia(parametros);
            return NoContent();
        }


        //BAJA FAMILIA
        [HttpPut("Baja_Familia/{id}")]
        public async Task<ActionResult> BajaFamilia(int id, [FromBody] Familia parametros)
        {
            var funcion = new DFamilia();
            parametros.Id = id;
            await funcion.BajaFamilia(parametros);
            return NoContent();
        }
    }
}
