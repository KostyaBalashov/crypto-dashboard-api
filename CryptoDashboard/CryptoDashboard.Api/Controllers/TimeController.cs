using CryptoDashboard.Datalayer.Coinbase;
using Microsoft.AspNetCore.Mvc;

namespace CryptoDashboard.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly Times _service;

        public TimeController(IConfiguration configuration)
        {
            _service = new Times(configuration.GetValue<string>("api:baseUrl"));
        }

        [HttpGet("GetTime")]
        public string Get()
        {
            return _service.GetTimeAsync().Result;
        }
    }
}
