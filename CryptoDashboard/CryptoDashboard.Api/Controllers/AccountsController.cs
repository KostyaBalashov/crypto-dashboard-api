using CryptoDashboard.Datalayer.Coinbase;
using CryptoDashboard.Datalayer.Coinbase.Model;
using CryptoDashboard.Datalayer.Coinbase.Model.Accounts;
using CryptoDashboard.Datalayer.Coinbase.Services;
using Microsoft.AspNetCore.Mvc;

namespace CryptoDashboard.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccountsController(IAccountService accountService)
        {
            _service = accountService;
        }

        [HttpGet("GetAccounts")]
        public Task<PaginatedResult<Account>> Get()
        {
            return _service.GetNextPageAsync(null);
        }
    }
}
