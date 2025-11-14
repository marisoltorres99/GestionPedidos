using GestionPedidos.Infraestructura;
using GestionPedidos.Model;

namespace GestionPedidos.Services
{
    public class GestionarPedidos
    {
        public List<PedidoConCliente> ObtenerPedidosConClientes()
        {
            var ca = new CargarArchivosCSV();
            var clientes = ca.CargarClientes();
            var pedidos = ca.CargarPedidos();

            var pedidosConClientes = (from c in clientes
                                      join p in pedidos on c.IdCliente equals p.IdCliente
                                      select new PedidoConCliente
                                      {
                                          IdPedido = p.IdPedido,
                                          NombreCliente = c.NombreCliente,
                                          Email = c.Email,
                                          MontoBase = p.MontoBase,
                                          TipoEnvio = p.TipoEnvio,
                                          Fecha = p.Fecha,
                                          MontoTotal = p.CalcularMontoTotal()
                                      }).ToList();

            return pedidosConClientes;

        }
    }
}
