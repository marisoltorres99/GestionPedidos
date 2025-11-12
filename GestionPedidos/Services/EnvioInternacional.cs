namespace GestionPedidos.Services
{
    public class EnvioInternacional : ICalculadorEnvio
    {
        private const decimal Porcentaje = 0.25m;
        public decimal CalcularCostoEnvio(decimal montoBase)
        {
            return montoBase + (montoBase * Porcentaje);
        }
    }
}
