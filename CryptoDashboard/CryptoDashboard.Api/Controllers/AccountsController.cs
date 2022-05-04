using CryptoDashboard.Datalayer.Coinbase;
using Microsoft.AspNetCore.Mvc;

namespace CryptoDashboard.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly Accounts _service;

        public AccountsController(IConfiguration configuration)
        {
            _service = new Accounts(
                configuration.GetValue<string>("api2:secret"),
                configuration.GetValue<string>("api2:key"),
                configuration.GetValue<string>("api2:baseUrl"));
        }

        [HttpGet("GetAccounts")]
        public string Get()
        {
            return _service.GetAccounts().Result;
        }
    }
}
