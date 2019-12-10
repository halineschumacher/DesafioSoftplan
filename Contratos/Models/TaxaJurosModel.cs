using Contratos.Domain.Errors;
using Contratos.Domain.Interfaces;

namespace Contratos.Domain.Models
{
    public class TaxaJurosModel: ErrorBase
    {
        public ITaxaDeJuros TaxaDeJuros { get; set; }

        public decimal Valor { get; set; }
    }
}