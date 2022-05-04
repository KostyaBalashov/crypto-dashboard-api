namespace CryptoDashboard.Datalayer.Coinbase.Core.Model
{
    public interface ICoinbaseEntityHash
    {
        Guid Id { get; set; }

        string Resource { get; set; }

        string ResourcePath { get; set; }
    }
}
