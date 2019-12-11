using Contratos.Domain.Interfaces;

namespace TaxaDeJuros.Domain
{
    public class TaxaDeJuros : ITaxaDeJuros
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }

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