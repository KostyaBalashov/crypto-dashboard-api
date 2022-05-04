using CryptoDashboard.Datalayer.Coinbase.Core.Model.Accounts;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;
using CryptoDashboard.Datalayer.Coinbase.Core.Services;
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

        [HttpGet]
        public Task<PaginatedResult<Account>> Get()
        {
            return _service.GetNextPageAsync(null);
        }

        [HttpGet("/{id}")]
        public Task<ApiResponse<Account>> Get([FromQuery] Guid id)
        {
            return _service.GetByIdAsync(id);
        }
    }
}
