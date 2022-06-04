using CryptoDashboard.Datalayer.Abstraction.Model;

namespace CryptoDashboard.Api.Models
{
    public class ExchangerInfo
    {
        public Exchanger? Exchanger { get; set; }

        public HealthCheckStatus? HealthCheck { get; set; }
    }
}
