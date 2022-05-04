using Newtonsoft.Json;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses
{
    [JsonObject("pagination")]
    public class Pagination
    {
        [JsonProperty("ending_before")]
        public Guid? EndingBefore { get; set; }

        [JsonProperty("starting_after")]
        public Guid? StartingAfter { get; set; }

        public int Limit { get; set; }

        public SortingOrder Order { get; set; }

        [JsonProperty("previous_uri")]
        public string PreviousUri { get; set; } = string.Empty;

        [JsonProperty("next_uri")]
        public string NextUri { get; set; } = string.Empty;
    }
}
