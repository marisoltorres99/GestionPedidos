using GestionPedidos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos.Model
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public decimal MontoBase { get; set; }
        public TiposDeEnvio TipoEnvio { get; set; }
        public DateTime Fecha { get; set; }

        public decimal CalcularMontoTotal()
        {
            var calculador = CalculadorEnvioFactory.ObtenerCalculador(TipoEnvio);
            return calculador.CalcularCostoEnvio(MontoBase);
        }
    }

    public enum TiposDeEnvio
    {
        Estandar,
        Express,
        Internacional
    }
}
