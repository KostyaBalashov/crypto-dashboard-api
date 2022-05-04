using CryptoDashboard.Datalayer.Coinbase.Core.Model.Buys;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;
using CryptoDashboard.Datalayer.Coinbase.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CryptoDashboard.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BuyController : ControllerBase
    {
        private readonly IBuyService _buyService;
        public BuyController(IBuyService service)
        {
            _buyService = service;
        }

        [HttpGet]
        public Task<PaginatedResult<Buy>> Get(Guid accountId)
        {
            return _buyService.GetNextPageAsync(accountId);
        }
    }
}
