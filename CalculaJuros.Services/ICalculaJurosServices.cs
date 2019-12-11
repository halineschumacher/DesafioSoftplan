using System.Threading.Tasks;

namespace CalculaJuros.Services
{
    public interface ICalculaJurosServices
    {
        Task<decimal>  GetValor(decimal valorInicial, int meses);
    }
}