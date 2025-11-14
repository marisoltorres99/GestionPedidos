namespace GestionPedidos.Model
{
    public class PedidoConCliente
    {
        public int IdPedido { get; set; }
        public string NombreCliente { get; set; }
        public string Email { get; set; }
        public decimal MontoBase { get; set; }
        public TiposDeEnvio TipoEnvio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
