namespace CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses
{
    public class ApiResponse<T>
    {
        public T Data { get; set; } = default!;

        public ICollection<AnomalyMessage> Warnings { get; set; } = new List<AnomalyMessage>();
    }
}
