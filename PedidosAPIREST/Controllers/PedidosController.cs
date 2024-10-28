using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedidosAPIREST.Modelos;
using PedidosAPIREST.Servicios;

namespace PedidosAPIREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly PedidoServicio _pedidoServicio;

        public PedidosController(PedidoServicio pedidoServicio)
        {
            _pedidoServicio = pedidoServicio;
        }

        // GET: api/pedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
        {
            var pedidos = await _pedidoServicio.ObtenerTodosPedidos();
            return Ok(pedidos);
        }

        // POST: api/pedidos
        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
        {
            try
            {
                var nuevoPedido = await _pedidoServicio.CrearPedido(pedido);
                return CreatedAtAction(nameof(GetPedidos), new { id = nuevoPedido.Id }, nuevoPedido);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
