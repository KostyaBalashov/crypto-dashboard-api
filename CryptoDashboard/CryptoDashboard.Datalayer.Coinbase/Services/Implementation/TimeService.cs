using CryptoDashboard.Datalayer.Coinbase.Core.Model;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;
using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Configuration;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Services.Implementation
{
    internal class TimeService : ITimeService
    {
        private readonly string _baseUrl;

        public TimeService(IConfiguration configuration) =>
            _baseUrl = configuration.GetValue<string>(Constants.COINBASE_BASE_URL);

        public Task<ApiResponse<CoinbaseTime>> GetCoinbaseTimeAsync()
        {
            return _baseUrl
                .AppendPathSegment(Constants.TIME_SEGMENT)
                .GetJsonAsync<ApiResponse<CoinbaseTime>>();
        }
    }
}
