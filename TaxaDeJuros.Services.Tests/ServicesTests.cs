using TaxaDeJuros.Repository;
using Assert = Xunit.Assert;
using Moq;
using Xunit;

namespace TaxaDeJuros.Services.Tests
{
    public class ServicesTests
    {
        private Mock<ITaxaDeJurosRepository> _mockRepository;
        private decimal valorEsperado = 0.01M;
        
        [Theory]
        [InlineData(0.01)]        
        public void TheoryTest(decimal valor)
        {
            _mockRepository = new Mock<ITaxaDeJurosRepository>();

            _mockRepository.Setup(s => s.GetValorTaxaDeJurosPadrao())
                .Returns(() => valorEsperado);

            var services = new TaxaDeJurosServices(_mockRepository.Object);
            decimal result = services.GetValor();

            Assert.Equal(valor, result);
        }

        [Fact]
        public void FactTest()
        {
            _mockRepository = new Mock<ITaxaDeJurosRepository>();
            
            _mockRepository.Setup(s => s.GetValorTaxaDeJurosPadrao())
                .Returns(() => valorEsperado);

            var services = new TaxaDeJurosServices(_mockRepository.Object);
            decimal result = services.GetValor();
            
            Assert.Equal(0.01M, result);
        }
    }
}