using System;
using Microsoft.AspNetCore.Mvc;
using CalculaJuros.Services;

namespace CalculaJuros.Api.Controllers
{
    [ApiController]
    [Route("/calculajuros")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosServices _calculaJurosServices;

        public CalculaJurosController(ICalculaJurosServices calculaJurosServices)
        {
            _calculaJurosServices = calculaJurosServices;
        }

        [HttpGet]
        public IActionResult Get(decimal valorInicial, int meses)
        {
            try
            {
                var retorno = _calculaJurosServices.GetValor(valorInicial, meses);
                return Ok(retorno);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao processar solicitação. Descrição: " + e.Message);
            }
        }
    }
}