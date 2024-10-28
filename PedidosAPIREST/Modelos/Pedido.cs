namespace PedidosAPIREST.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }  // Clave primaria
        public string Articulo { get; set; } = string.Empty;
        public int Cantidad { get; set; }
    }
}
