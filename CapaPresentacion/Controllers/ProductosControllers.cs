using Microsoft.AspNetCore.Mvc;
using CapaLogicaNegocio;

namespace CapaPresentacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private static List<Producto> productos = new List<Producto>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(productos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            productos.Add(producto);
            return CreatedAtAction(nameof(Get), new { id = producto.Id }, producto);
        }
    }
}
