using Microsoft.AspNetCore.Mvc;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService _service;

        public Magic8BallController(Magic8BallService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<string> AskQuestion([FromQuery] string question)
        {
            if (string.IsNullOrEmpty(question))
                return BadRequest("Please ask a question.");

            return Ok(_service.GetResponse(question));
        }
    }
}
