using Microsoft.AspNetCore.Mvc;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsService _service;

        public AskingQuestionsController(AskingQuestionsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<string> AskQuestion([FromQuery] string wakeUpTime, [FromQuery] string food)
        {
            if (string.IsNullOrEmpty(wakeUpTime))
                return BadRequest("Please provide what time you got up.");
            
            if (string.IsNullOrEmpty(food))
                return BadRequest("Please provide what you ate.");

            return Ok(_service.ProcessAnswer(wakeUpTime, food));
        }
    }
}
