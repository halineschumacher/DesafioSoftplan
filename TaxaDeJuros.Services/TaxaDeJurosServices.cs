using TaxaDeJuros.Repository;

namespace TaxaDeJuros.Services
{
    public class TaxaDeJurosServices : ITaxaDeJurosServices
    {
        private readonly ITaxaDeJurosRepository _taxaDeJurosRepository;
        public TaxaDeJurosServices(ITaxaDeJurosRepository taxaDeJurosRepository)
        {
            _taxaDeJurosRepository = taxaDeJurosRepository;
        }
        
        public decimal GetValor()
        {
            return _taxaDeJurosRepository.GetValorTaxaDeJurosPadrao();
        }
    }
}