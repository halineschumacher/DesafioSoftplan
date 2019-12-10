using TaxaDeJuros.Infra.CrossCutting;

namespace TaxaDeJuros.Services
{
    public class TaxaDeJurosServices : ITaxaDeJurosServices
    {
        public decimal GetValor()
        {
            return TaxaDeJurosConstants.ValorDaTaxaDeJuros;
        }
    }
}