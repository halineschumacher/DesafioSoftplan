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
        private readonly IHttpClientFactory _httpClientFactory;
        private const string Endpoint = "taxaJuros";
        
        public RetornaTaxaJurosClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        private HttpClient GetClient() => _httpClientFactory.CreateClient("taxaJuros");

        public async Task<TaxaJurosModel> GetAsync()
        {
            var responseMessage = await GetClient().GetAsync(Endpoint);
            return responseMessage.IsSuccessStatusCode ? await OnSuccess(responseMessage) : OnError(responseMessage);
        }

        private async Task<TaxaJurosModel> OnSuccess(HttpResponseMessage responseMessage)
        {
            var resultAsString = await responseMessage.Content.ReadAsStringAsync();
            return new TaxaJurosModel
            {
                Valor = decimal.Parse(resultAsString, CultureInfo.InvariantCulture)
            };
        }

        private TaxaJurosModel OnError(HttpResponseMessage responseMessage)
        {
            var model = new TaxaJurosModel();
            model.AddError(responseMessage.ToString());
            return model;
        }
    }
}