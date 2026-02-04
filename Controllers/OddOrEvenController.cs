using Microsoft.AspNetCore.Mvc;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _service;

        public OddOrEvenController(OddOrEvenService service)
        {
            _service = service;
        }

        [HttpGet("{number}")]
        public ActionResult<string> CheckOddOrEven(int number)
        {
            return Ok(_service.CheckOddOrEven(number));
        }
    }
}
