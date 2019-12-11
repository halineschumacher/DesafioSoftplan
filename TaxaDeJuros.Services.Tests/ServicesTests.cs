using TaxaDeJuros.Repository;
using Xunit;

namespace TaxaDeJuros.Services.Tests
{
    public class ServicesTests
    {
        [Theory]
        [InlineData(-5.001)]
        [InlineData(0.1)]
        [InlineData(0)]
        [InlineData(12.0000001)]
        [InlineData(1.1)]
        [InlineData(-1.5)]
        [InlineData(0.01)]
        public void TesteTheory(decimal valor)
        {
            //var tx = new TaxaDeJurosServices();
            //var value = tx.GetValor();

            //Assert.Equal(value, valor);
        }
        
        [Fact]
        public void TesteFact()
        {
            //var tx = new TaxaDeJurosServices(new TaxaDeJurosRepository());
            //var value = tx.GetValor();

            //Assert.Equal(0.01M, value);
        }

    }
}