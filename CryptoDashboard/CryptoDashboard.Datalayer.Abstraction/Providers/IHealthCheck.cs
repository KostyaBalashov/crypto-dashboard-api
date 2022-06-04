using CryptoDashboard.Datalayer.Abstraction.Model;

namespace CryptoDashboard.Datalayer.Abstraction.Providers
{
    public interface IHealthCheck : IExchangerSpecific
    {
        Task<HealthCheckStatus> HealthCheckAsync();
    }
}
