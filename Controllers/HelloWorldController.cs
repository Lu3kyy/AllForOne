using Microsoft.AspNetCore.Mvc;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldService _service;

        public HelloWorldController(HelloWorldService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok(_service.GetMessage());
        }
    }
}
