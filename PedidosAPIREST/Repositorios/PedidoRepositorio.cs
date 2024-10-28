using PedidosAPIREST.Data;
using PedidosAPIREST.Modelos;
using Microsoft.EntityFrameworkCore;


namespace PedidosAPIREST.Repositorios
{
    public class PedidoRepositorio : IPedidoRepositorio
    {
        private readonly PedidosContext _context;

        public PedidoRepositorio(PedidosContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pedido>> ObtenerTodos()
        {
            return await _context.Pedidos.ToListAsync();
        }

        public async Task<Pedido> Crear(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }
    }
}
