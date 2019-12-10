using System;
using Microsoft.AspNetCore.Mvc;
using TaxaDeJuros.Services;

namespace TaxaDeJuros.Api.Controllers
{
    [ApiController]
    [Route("/taxaJuros")]
    public class TaxaDeJurosController : ControllerBase
    {
        private readonly ITaxaDeJurosServices _taxaDeJurosServices;
        
        public TaxaDeJurosController(ITaxaDeJurosServices taxaDeJurosServices)
        {
            _taxaDeJurosServices = taxaDeJurosServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_taxaDeJurosServices.GetValor());
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao processar solicitação. Descrição: " + e.Message);
            }
        }
    }
}