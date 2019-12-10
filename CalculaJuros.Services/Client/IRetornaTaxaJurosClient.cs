using System.Threading.Tasks;
using Contratos.Domain.Models;

namespace CalculaJuros.Services.Client
{
    public interface IRetornaTaxaJurosClient
    {
         Task<TaxaJurosModel> GetAsync();
    }
}