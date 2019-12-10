using System;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Contratos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CalculaJuros.Services.Client
{
    public class RetornaTaxaJurosClient : IRetornaTaxaJurosClient
    {
        private const string Endpoint = "taxaJuros";
        private readonly IHttpClientFactory _httpClientFactory;

        public RetornaTaxaJurosClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<TaxaJurosModel> GetAsync()
        {
            try
            {
                var responseMessage = await GetClient().GetAsync(Endpoint);

                return responseMessage.IsSuccessStatusCode
                    ? await OnSuccess(responseMessage)
                    : OnError(responseMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine("Não entrou no OnError: " + e.Message);
                throw;
            }
        }

        private HttpClient GetClient() => _httpClientFactory.CreateClient("taxaJuros");

        private TaxaJurosModel OnError(HttpResponseMessage responseMessage)
        {
            TaxaJurosModel dto = new TaxaJurosModel();
            dto.AddError(responseMessage.ToString());
            return dto;
        }

        private async Task<TaxaJurosModel> OnSuccess(HttpResponseMessage responseMessage)
        {
            var resultAsString = await responseMessage.Content.ReadAsStringAsync();
            return new TaxaJurosModel {Valor = decimal.Parse(resultAsString, CultureInfo.InvariantCulture)};
        }
    }
}