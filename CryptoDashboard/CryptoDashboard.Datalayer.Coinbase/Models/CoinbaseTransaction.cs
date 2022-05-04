using CryptoDashboard.Datalayer.Abstraction.Model;

namespace CryptoDashboard.Datalayer.Coinbase.Models
{
    internal class CoinbaseTransaction : Transaction
    {
        public CoinbaseTransaction(Guid id, TransactionStatus status) 
            : base(id, status)
        {
        }
    }
}
