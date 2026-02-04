using Microsoft.AspNetCore.Mvc;
using project_template.Services;

namespace project_template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _service;

        public RestaurantPickerController(RestaurantPickerService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<string> PickRandom()
        {
            return Ok(_service.PickRandomRestaurant());
        }
    }
}
