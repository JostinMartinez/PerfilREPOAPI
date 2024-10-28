using PedidosAPIREST.Modelos;

namespace PedidosAPIREST.Repositorios
{
    public interface IPedidoRepositorio
    {
        Task<IEnumerable<Pedido>> ObtenerTodos();
        Task<Pedido> Crear(Pedido pedido);
    }
}
