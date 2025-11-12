
namespace GestionPedidos.Services
{
    public interface ICalculadorEnvio
    {
        public decimal CalcularCostoEnvio(decimal montoBase);
    }
}
