using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase
{
    public class Accounts
    {
        private static readonly string _segment = "accounts/";

        private readonly string _secret;
        private readonly string _key;
        private readonly string _baseUrl;
        private readonly Times _service;

        public Accounts(string secret, string key, string baseUrl)
        {
            _secret = secret;
            _key = key;
            _baseUrl = baseUrl;

            _service = new Times(_baseUrl);
        }

        public async Task<string> GetAccounts()
        {
            var coinbaseTime = await _service.GetCoinbaseTime();
            var signature = string.Empty;

            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_secret)))
            {
                var message = coinbaseTime.Epoch + "GET" + "/v2/accounts";
                var t = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
                signature = Convert.ToHexString(t).ToLowerInvariant();
            }

            var query = _baseUrl
                .AppendPathSegment(_segment)
                .WithHeaders(new
                {
                    CB_ACCESS_KEY = _key,
                    CB_ACCESS_SIGN = signature,
                    CB_ACCESS_TIMESTAMP = coinbaseTime.Epoch,
                    Accept_Language = "fr",
                    CB_VERSION = "2021-02-18",
                    Accept = "*/*",
                    UserAgent = ".NET",
                    ContentType = "application/json"
                });

            return await query.GetStringAsync();
        }
    }
}
