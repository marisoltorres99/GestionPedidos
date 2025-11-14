using GestionPedidos.Model;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionPedidos.Infraestructura
{
    public class CargarArchivosCSV
    {
        private readonly string rutaClientes = @"Data\clientes.csv";
        private readonly string rutaPedidos = @"Data\pedidos.csv";
        public List<Cliente> CargarClientes()
        {
            var clientes = new List<Cliente>();
            try
            {
                var lineas = File.ReadAllLines(rutaClientes);
                for (int i = 1; i < lineas.Length; i++)
                {
                    var partes = lineas[i].Split(',');
                    var cliente = new Cliente
                    {
                        IdCliente = int.Parse(partes[0]),
                        NombreCliente = partes[1],
                        Email = partes[2]
                    };
                    clientes.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar clientes desde archivo CSV");
            }
            return clientes;
        }

        public List<Pedido> CargarPedidos()
        {
            var pedidos = new List<Pedido>();
            try
            {
                var lineas = File.ReadAllLines(rutaPedidos);
                for (int i = 1; i < lineas.Length; i++)
                {
                    var partes = lineas[i].Split(',');
                    var pedido = new Pedido
                    {
                        IdPedido = int.Parse(partes[0]),
                        IdCliente = int.Parse(partes[1]),
                        MontoBase = decimal.Parse(partes[2], CultureInfo.InvariantCulture),
                        TipoEnvio = Enum.Parse<TiposDeEnvio>(partes[3], ignoreCase: true),
                        Fecha = DateTime.Parse(partes[4])
                    };
                    pedidos.Add(pedido);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar clientes desde archivo CSV");
            }
            return pedidos;
        }
    }
}
