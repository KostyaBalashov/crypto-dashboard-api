using CryptoDashboard.Datalayer.Coinbase.Model.Hashs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Model.Buys
{
    public class Buy : CoinbaseEntity
    {
        public Status Status { get; set; }

        public PaymentMethodHash PaymentMethod { get; set; } = new PaymentMethodHash();

        public TransactionHash Transaction { get; set; } = new TransactionHash();

        public MoneyValue Amount { get; set; } = new MoneyValue(0, string.Empty);

        public MoneyValue Total { get; set; } = new MoneyValue(0, string.Empty);

        public MoneyValue Subtotal { get; set; } = new MoneyValue(0, string.Empty);

        public bool Committed { get; set; }

        public bool Instant { get; set; }

        public MoneyValue Fee { get; set; } = new MoneyValue(0, string.Empty);

        public DateTimeOffset PayoutAt { get; set; }
    }
}
