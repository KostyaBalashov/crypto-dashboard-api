using CryptoDashboard.Datalayer.Abstraction.Model;
using CryptoDashboard.Datalayer.Abstraction.Providers;

namespace CryptoDashboard.Datalayer.Empty
{
    internal class HealthCheck : IHealthCheck
    {
        public Exchanger Exchanger => EmptyExchanger.Exchanger;

        public Task<HealthCheckStatus> HealthCheckAsync()
        {
            return Task.FromResult<HealthCheckStatus>(new EmptyHealthCheckStatus() 
            { 
                StatusCode = 200, 
                Description = "OK" 
            });
        }
    }
}
