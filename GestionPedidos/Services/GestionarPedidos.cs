using GestionPedidos.Infraestructura;
using GestionPedidos.Model;

namespace GestionPedidos.Services
{
    public class GestionarPedidos
    {
        public List<PedidosAgrupadosPorCliente> ObtenerPedidosAgrupados()
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

            var pedidosAgrupados = (from pc in pedidosConClientes
                                    group pc by new { pc.NombreCliente, pc.Email } into grupo
                                    select new PedidosAgrupadosPorCliente
                                    {
                                        NombreCliente = grupo.Key.NombreCliente,
                                        Email = grupo.Key.Email,
                                        TotalPedidos = grupo.Count(),
                                        TotalFacturado = grupo.Sum(p => p.MontoTotal),
                                    }).ToList();

            return pedidosAgrupados;

        }
    }
}
