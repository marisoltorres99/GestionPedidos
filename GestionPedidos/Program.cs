using GestionPedidos.Services;

namespace GestionPedidos
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gestor = new GestionarPedidos();
            var pedidosAgrupados = gestor.ObtenerPedidosAgrupados();

            foreach (var p in pedidosAgrupados)
            {
                Console.WriteLine($"Cliente: {p.NombreCliente} ({p.Email})");
                Console.WriteLine($"Total de pedidos: {p.TotalPedidos}");
                Console.WriteLine($"Total facturado: {p.TotalFacturado:C}");
                Console.WriteLine(new string('-', 40));
            }

            Console.ReadLine();
        }
    }
}
