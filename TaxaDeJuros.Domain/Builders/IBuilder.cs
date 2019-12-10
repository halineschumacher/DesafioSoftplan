namespace TaxaDeJuros.Domain.Builders
{
    public interface IBuilder<out T>
    {
        T Build();
    }
}