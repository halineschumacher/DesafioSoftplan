namespace CalculaJuros.Services
{
    public interface ICalculaJurosServices
    {
        decimal GetValor(decimal valorInicial, int meses);
    }
}