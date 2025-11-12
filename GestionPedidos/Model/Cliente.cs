namespace GestionPedidos.Model
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Email { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
