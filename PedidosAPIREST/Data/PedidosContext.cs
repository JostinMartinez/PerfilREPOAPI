using Microsoft.EntityFrameworkCore;
using PedidosAPIREST.Modelos;

namespace PedidosAPIREST.Data
{
    public class PedidosContext : DbContext
    {
        public PedidosContext(DbContextOptions<PedidosContext> options) : base(options) { }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
