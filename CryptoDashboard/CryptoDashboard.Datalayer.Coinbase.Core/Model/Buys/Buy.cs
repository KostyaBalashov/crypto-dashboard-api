using CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Hashs;
using Newtonsoft.Json;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Model.Buys
{
    public class Buy : CoinbaseEntity
    {
        public Status Status { get; set; }

        [JsonProperty("payment_method")]
        public PaymentMethodHash PaymentMethod { get; set; } = new PaymentMethodHash();

        public TransactionHash Transaction { get; set; } = new TransactionHash();

        public MoneyValue Amount { get; set; } = new MoneyValue(0, string.Empty);

        public MoneyValue Total { get; set; } = new MoneyValue(0, string.Empty);

        public MoneyValue Subtotal { get; set; } = new MoneyValue(0, string.Empty);

        public bool Committed { get; set; }

        public bool Instant { get; set; }

        public MoneyValue Fee { get; set; } = new MoneyValue(0, string.Empty);

        [JsonProperty("payout_at")]
        public DateTimeOffset PayoutAt { get; set; }
    }
}
