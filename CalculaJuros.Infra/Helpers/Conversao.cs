namespace CalculadoraJuros.Infra.Helpers
{
    public class Conversao
    {
        public decimal TruncaDecimalInTwoPlaces(decimal number)
        {
            return decimal.Parse(number.ToString("##.00"));
        }
    }
}