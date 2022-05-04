using CryptoDashboard.Datalayer.Coinbase.Core.Services;
using CryptoDashboard.Datalayer.Coinbase.Core.Signer;
using Flurl.Http;
using Microsoft.Extensions.Configuration;
using System.Globalization;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Configuration
{
    internal class ApiKeyConfiguration : ApiConfiguration
    {
        private readonly IApiKeySigner _signer;
        private readonly ITimeService _timeService;

        public ApiKeyConfiguration(IApiKeySigner apiKeySigner, ITimeService timeService, IConfiguration configuration)
            : base(configuration)
        {
            _signer = apiKeySigner;
            _timeService = timeService;

            ApiKey = configuration.GetValue<string>(Constants.COIBASE_KEY);
            ApiSecret = configuration.GetValue<string>(Constants.COINBASE_SECRET);
        }

        public virtual string ApiKey { get; set; }

        public virtual string ApiSecret { get; set; }

        public override void Configure(IFlurlClient client)
        {
            client.Configure(settings =>
            {
                settings.BeforeCallAsync = SetHeaders;
            });
        }

        private async Task SetHeaders(FlurlCall call)
        {
            var coinbaseTime = await _timeService.GetCoinbaseTimeAsync();

            var httpMethod = call.Request.Verb.Method.ToUpperInvariant();
            var body = call.RequestBody;
            var requestPath = call.Request.Url.ToUri().PathAndQuery;

            call.Request.WithHeaders(new
            {
                CB_ACCESS_KEY = ApiKey,
                CB_ACCESS_SIGN = _signer.Signe(coinbaseTime.Data.Epoch.ToString(CultureInfo.InvariantCulture), httpMethod, requestPath, body, ApiSecret),
                CB_ACCESS_TIMESTAMP = coinbaseTime.Data.Epoch,
                CB_VERSION = ApiVersion,
                Accept_Language = "fr",
                Accept = "*/*",
                UserAgent = ".NET",
                ContentType = "application/json"
            });
        }
    }
}
