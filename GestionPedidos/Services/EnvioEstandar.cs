namespace GestionPedidos.Services
{
    public class EnvioEstandar : ICalculadorEnvio
    {
        private const decimal Porcentaje = 0.05m;
        public decimal CalcularCostoEnvio(decimal montoBase)
        {
            return montoBase + (montoBase * Porcentaje);
        }
    }
}
