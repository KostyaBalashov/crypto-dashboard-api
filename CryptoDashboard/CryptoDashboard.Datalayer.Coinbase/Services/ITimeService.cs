using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Services
{
    internal interface ITimeService
    {
        Task<CoinbaseTime> GetCoinbaseTimeAsync();
    }

    [JsonConverter(typeof(CoinTimeJsonConverter))]
    public class CoinbaseTime
    {
        public DateTimeOffset Iso { get; set; }

        public long Epoch { get; set; }
    }

    public class CoinTimeJsonConverter : JsonConverter
    {
        private const string ISO_PATH = "data.iso";
        private const string EPOCH_PATH = "data.epoch";

        public override bool CanConvert(Type objectType)
        {
            return objectType != null && objectType == typeof(CoinbaseTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            CoinbaseTime value = new();

            while (reader.Read())
            {
                switch (reader.Path)
                {
                    case ISO_PATH:
                        if (reader.TokenType == JsonToken.Date)
                        {
                            value.Iso = DateTimeOffset.Parse(reader.Value.ToString()!);
                        }
                        break;
                    case EPOCH_PATH:
                        if (reader.TokenType == JsonToken.Integer)
                        {
                            value.Epoch = long.Parse(reader.Value.ToString()!);
                        }
                        break;
                    default:
                        continue;
                }
            }

            return value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
