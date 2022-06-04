using CryptoDashboard.Datalayer.Abstraction.Model;
using CryptoDashboard.Datalayer.Abstraction.Providers;
using CryptoDashboard.Datalayer.Coinbase.Core.Services;
using CryptoDashboard.Datalayer.Coinbase.Models;

namespace CryptoDashboard.Datalayer.Coinbase.Providers
{
    internal class HealthCheck : IHealthCheck
    {
        private readonly ITimeService _timeService;

        public HealthCheck(ITimeService timeService) =>
            _timeService = timeService;

        public Exchanger Exchanger => CoinbaseExchanger.Exchanger;

        public async Task<HealthCheckStatus> HealthCheckAsync()
        {
            HealthCheckStatus status;
            try
            {
                await _timeService.GetCoinbaseTimeAsync();
                status = new CoinbaseHealthCheckStatus() { StatusCode = 200, Description = "OK" };
            }
            catch (Exception ex)
            {
                status = new CoinbaseHealthCheckStatus() { StatusCode = 500, Description = ex.Message };
            }

            return status;
        }
    }
}
