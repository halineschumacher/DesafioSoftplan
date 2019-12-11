using System.ComponentModel.Design;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TaxaDeJuros.Infra.Data;

namespace TaxaDeJuros.Repository
{
    public class TaxaDeJurosRepository : ITaxaDeJurosRepository
    {
        private readonly ITaxaDeJurosContext _taxaDeJurosContext;

        public TaxaDeJurosRepository(ITaxaDeJurosContext taxaDeJurosContext)
        {
            _taxaDeJurosContext = taxaDeJurosContext;
        }

        public decimal GetValorTaxaDeJurosPadrao()
        {
            return _taxaDeJurosContext.TaxaDeJuros.Select(d => d.Valor).FirstOrDefault();
        }
    }
}