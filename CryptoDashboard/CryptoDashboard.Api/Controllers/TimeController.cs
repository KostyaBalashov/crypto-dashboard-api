using CryptoDashboard.Datalayer.Coinbase.Core.Model;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;
using CryptoDashboard.Datalayer.Coinbase.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CryptoDashboard.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private ITimeService _service;

        public TimeController(ITimeService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<ApiResponse<CoinbaseTime>> Get()
        {
            return _service.GetCoinbaseTimeAsync();
        }
    }
}
