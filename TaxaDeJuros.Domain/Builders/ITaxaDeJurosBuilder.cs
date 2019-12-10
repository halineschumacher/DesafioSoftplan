namespace TaxaDeJuros.Domain.Builders
{
    public interface ITaxaDeJurosBuilder<out T> : IBuilder<T>
    {
        ITaxaDeJurosBuilder<T> WithValor(decimal valor);
    }
}