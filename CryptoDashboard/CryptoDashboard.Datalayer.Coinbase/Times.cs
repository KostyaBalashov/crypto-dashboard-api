using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase
{
    public class Times
    {
        private static readonly string _segment = "time";

        private readonly string _baseUrl;

        public Times(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public Task<string> GetTimeAsync()
        {
            return _baseUrl
                .AppendPathSegment(_segment)
                .GetStringAsync();
        }

        public Task<CoinTime> GetCoinbaseTime()
        {
            return _baseUrl
                .AppendPathSegment(_segment)
                .GetJsonAsync<CoinTime>();
        }

        [JsonConverter(typeof(CoinTimeJsonConverter))]
        public class CoinTime
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
                return objectType != null && objectType == typeof(CoinTime);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                CoinTime value = new();

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
}
