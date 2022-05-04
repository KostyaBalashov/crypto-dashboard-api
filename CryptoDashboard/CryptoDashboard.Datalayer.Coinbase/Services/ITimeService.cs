using CryptoDashboard.Datalayer.Coinbase.Core.Model;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Services
{
    public interface ITimeService
    {
        Task<ApiResponse<CoinbaseTime>> GetCoinbaseTimeAsync();
    }
}
