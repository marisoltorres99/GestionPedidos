using GestionPedidos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos.Services
{
    public class CalculadorEnvioFactory
    {
        public static ICalculadorEnvio ObtenerCalculador(TiposDeEnvio tipoEnvio)
        {
            return tipoEnvio switch
            {
                TiposDeEnvio.Estandar => new EnvioEstandar(),
                TiposDeEnvio.Express => new EnvioExpress(),
                TiposDeEnvio.Internacional => new EnvioInternacional(),
                _ => throw new ArgumentException("Tipo de envío no válido")
            };
        }
    }
}
