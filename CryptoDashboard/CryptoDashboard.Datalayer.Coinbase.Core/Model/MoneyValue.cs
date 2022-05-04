namespace CryptoDashboard.Datalayer.Coinbase.Core.Model
{
    public class MoneyValue
    {
        public MoneyValue(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; set; }

        public string Currency { get; set; }
    }
}
