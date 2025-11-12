namespace GestionPedidos.Services
{
    public class EnvioExpress : ICalculadorEnvio
    {
        private const decimal Porcentaje = 0.15m;
        public decimal CalcularCostoEnvio(decimal montoBase)
        {
            return montoBase + (montoBase * Porcentaje);
        }
    }
}
