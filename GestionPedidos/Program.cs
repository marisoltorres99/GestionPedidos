using GestionPedidos.Services;

namespace GestionPedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gestor = new GestionarPedidos();
            var pedidosConClientes = gestor.ObtenerPedidosConClientes();

            foreach (var p in pedidosConClientes)
            {
                Console.WriteLine($"{p.IdPedido} - {p.NombreCliente} - {p.MontoTotal}");
            }

            Console.ReadLine();
        }
    }
}
