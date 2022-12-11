using Mercaderia.Entities;
using Mercaderia.Datos;
using Microsoft.AspNetCore.Mvc;

namespace Mercaderia.Controllers
{
    [ApiController]
    [Route("api/producto")]
    public class ProductoController : ControllerBase
    {
        
        //LISTADO PRODUCTO
        [HttpGet("codigoproducto")]
        public async Task <ActionResult<List<Producto>>> ListadoProducto(string codigoproducto, Producto parametros)
        {
            var funcion = new DProducto();
            parametros.CodigoProducto = codigoproducto;
            var lista = await funcion.ListadoProductos(parametros);
            return lista;
        }

        //ALTA PRODUCTO
        [HttpPost]
        public async Task AltaProducto([FromBody] Producto parametros)
        {
            var funcion = new DProducto();
            await funcion.AltaProducto(parametros);
        }

        //MODIFICACION PRODUCTO
        [HttpPut("Modificacion_Producto/{codigoproducto}")]
        public async Task <ActionResult> ModificarProducto(string codigoproducto, [FromBody] Producto parametros)
        {
            var funcion = new DProducto();
            parametros.CodigoProducto = codigoproducto;
            await funcion.ModificacionProducto(parametros);
            return NoContent();
        }


        [HttpPut("Baja_Producto/{codigoproducto}")]
        public async Task<ActionResult> DarDeBajaProducto(string codigoproducto, [FromBody] Producto parametros)
        {
            var funcion = new DProducto();
            parametros.CodigoProducto = codigoproducto;
            await funcion.BajaProducto(parametros);
            return NoContent();
        }
    }
}
