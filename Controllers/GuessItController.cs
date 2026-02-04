using Microsoft.AspNetCore.Mvc;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _service;

        public GuessItController(GuessItService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<string> Guess([FromQuery] int number)
        {
            return Ok(_service.MakeGuess(number));
        }
    }
}
