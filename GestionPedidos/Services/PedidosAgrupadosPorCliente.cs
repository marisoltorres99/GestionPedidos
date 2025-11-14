using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos.Services
{
    public class PedidosAgrupadosPorCliente
    {
        public string NombreCliente { get; set; }
        public string Email { get; set; }
        public int TotalPedidos { get; set; }
        public decimal TotalFacturado { get; set; }
    }
}
