using Microsoft.AspNetCore.Mvc;
using CapaLogicaNegocio;
using System.Linq;

namespace CapaPresentacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private static List<Pedido> pedidos = new List<Pedido>();

        [HttpGet("{id}/resumen")]
        public IActionResult GetResumen(int id)
        {
            var pedido = pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido == null)
            {
                return NotFound(new { Message = "Pedido no encontrado." });
            }

            var resumen = new
            {
                Cliente = pedido.Cliente.Nombre,
                Correo = pedido.Cliente.Correo,
                Productos = pedido.ListaDeProductos.Select(p => new { p.Nombre, p.Precio }),
                Total = pedido.Total
            };

            return Ok(resumen);
        }
    }
}
