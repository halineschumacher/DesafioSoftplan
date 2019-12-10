using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Api.Controllers
{
    [ApiController]
    [Route("/showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("https://github.com/halineschumacher/DesafioSoftplan");
        }
    }
}