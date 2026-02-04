using Microsoft.AspNetCore.Mvc;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReverseController : ControllerBase
    {
        private readonly ReverseService _service;

        public ReverseController(ReverseService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<string> Reverse([FromQuery] string input)
        {
            if (string.IsNullOrEmpty(input))
                return BadRequest("Please provide input to reverse.");

            string reversed = _service.Reverse(input);
            return Ok(new { original = input, reversed });
        }
    }
}
