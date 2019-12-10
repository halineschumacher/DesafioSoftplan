using Contratos.Domain.Interfaces;

namespace TaxaDeJuros.Domain
{
    public class TaxaDeJuros : ITaxaDeJuros
    {
        private int Id { get; set; }
        private decimal Valor { get; set; }

        public decimal Get() => Valor;
        
        public TaxaDeJuros()
        {
        }

        public TaxaDeJuros(decimal valor)
        {
            SetValor(valor);
        }
        
        private void SetValor(decimal valor) => Valor = valor;
    }
}