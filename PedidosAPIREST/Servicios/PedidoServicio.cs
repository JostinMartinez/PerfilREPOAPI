using PedidosAPIREST.Modelos;
using PedidosAPIREST.Repositorios;

namespace PedidosAPIREST.Servicios
{
    public class PedidoServicio
    {

        private readonly IPedidoRepositorio _pedidoRepositorio;

        public PedidoServicio(IPedidoRepositorio pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        public async Task<IEnumerable<Pedido>> ObtenerTodosPedidos()
        {
            return await _pedidoRepositorio.ObtenerTodos();
        }

        public async Task<Pedido> CrearPedido(Pedido pedido)
        {
            if (string.IsNullOrWhiteSpace(pedido.Articulo))
            {
                throw new ArgumentException("El artículo no puede estar vacío.");
            }

            return await _pedidoRepositorio.Crear(pedido);
        }
    }
}
