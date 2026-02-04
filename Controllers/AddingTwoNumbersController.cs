using Microsoft.AspNetCore.Mvc;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersService _service;

        public AddingTwoNumbersController(AddingTwoNumbersService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<int> Add([FromQuery] int number1, [FromQuery] int number2)
        {
            int result = _service.Add(number1, number2);
            return Ok(new { number1, number2, result });
        }

        [HttpGet("compare")]
        public ActionResult<string> Compare([FromQuery] int number1, [FromQuery] int number2)
        {
            string result = _service.Compare(number1, number2);
            return Ok(result);
        }
    }
}
