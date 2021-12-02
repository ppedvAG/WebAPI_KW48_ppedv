using DefaultWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DefaultWebAPI.Controllers
{
    //https://localhost:5001/api/TimeService
    [Route("api/[controller]")]
    [ApiController]
    public class TimeServiceController : ControllerBase
    {
        private readonly ITimeService _timeServce;

        public TimeServiceController(ITimeService timeService)
        {
            _timeServce = timeService;
        }

        [HttpGet]
        public DateTime GetCurrentTime()
        {
            return _timeServce.GetCurrentTime();
        }
    }
}
