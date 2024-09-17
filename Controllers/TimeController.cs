using laboratorna_3.Services;
using Microsoft.AspNetCore.Mvc;

namespace laboratorna_3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly TimeService _timeService;

        public TimeController(TimeService timeService)
        {
            _timeService = timeService;
        }

        [HttpGet("current-time")]
        public IActionResult GetCurrentTime()
        {
            return Ok(_timeService.GetTimeOfDay());
        }
    }
}
