namespace CryptoDashboard.Datalayer.Coinbase.Core.Model
{
    public interface ICoinbaseHorodatageHash
    {
        DateTimeOffset CreatedAt { get; set; }

        DateTimeOffset UpdatedAt { get; set; }
    }
}
