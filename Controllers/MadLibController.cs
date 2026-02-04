using Microsoft.AspNetCore.Mvc;
using project_template.Models;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _service;

        public MadLibController(MadLibService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<string> GenerateMadLib([FromBody] MadLibRequest request)
        {
            if (request == null)
                return BadRequest("Please provide all MadLib inputs.");

            string story = _service.GenerateMadLib(request);
            return Ok(story);
        }
    }
}
