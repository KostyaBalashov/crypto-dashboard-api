namespace CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses
{
    public class ApiErrorResponse
    {
        public ICollection<AnomalyMessage> Errors { get; set; } = new List<AnomalyMessage>();
    }
}
