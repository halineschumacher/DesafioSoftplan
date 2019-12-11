using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using RestSharp;
using Xunit;

namespace TaxaDeJuros.Api.IntegrationTests
{
    public class ApiIntegrationTests
    {
        [Theory]
        [InlineData(0.01)]
        public void GetAllTestAsync(decimal value)
        {
            var client = new RestClient("http://localhost:5000/");
            var request = new RestRequest("taxaJuros", Method.GET);

            IRestResponse response = client.Execute(request);
            var content = response.Content;
            decimal result = decimal.Parse(content, CultureInfo.InvariantCulture);
            
            Assert.Equal(value, result);
        }
    }
}