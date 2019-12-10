using System;
using System.Runtime.CompilerServices;
using CalculaJuros.Services.Client;
using System.Threading.Tasks;
using CalculadoraJuros.Infra.Helpers;
using Contratos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CalculaJuros.Services
{
    public class CalculaJurosServices : ICalculaJurosServices
    {
        private readonly IRetornaTaxaJurosClient _retornaTaxaJurosClient;
        
        public CalculaJurosServices(IRetornaTaxaJurosClient retornaTaxaJurosClient)
        {
            _retornaTaxaJurosClient = retornaTaxaJurosClient;
        }

        public decimal GetValor(decimal valorInicial, int meses)
        {
            try
            {
                if (valorInicial <= 0)
                    throw new InvalidOperationException("É necessário informar o valor inicial para o cálculo.");

                var taxaJuros = GetAsync().Result;
                var resultado = Calcular(valorInicial, taxaJuros.Valor, meses);
                return new Conversao().TruncaDecimalInTwoPlaces(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private async Task<TaxaJurosModel> GetAsync()
        {
            return await _retornaTaxaJurosClient.GetAsync();
        }

        private decimal Calcular(decimal valorInicial, decimal taxaDeJuros, int meses)
        {
            var pow = Math.Pow((double)(1 + taxaDeJuros), meses);
            var result = valorInicial * (decimal)pow;

            return result;
        }
    }
}