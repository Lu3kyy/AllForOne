using Microsoft.AspNetCore.Mvc;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReverseNumbersController : ControllerBase
    {
        private readonly ReverseNumbersService _service;

        public ReverseNumbersController(ReverseNumbersService service)
        {
            _service = service;
        }

        [HttpGet("{number}")]
        public ActionResult<string> ReverseNumber(int number)
        {
            string reversed = _service.ReverseNumber(number);
            return Ok(new { original = number, reversed });
        }
    }
}
